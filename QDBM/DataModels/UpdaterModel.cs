using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace QPAD
{
    class UpdaterModel : BindableBase
    {
        #region Constructor
        public UpdaterModel(int CurrentVersion)
        {
            this.CurrentVersion = CurrentVersion;
            string localAppDataPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData) + @"\MUIA\QDBM\";
            if (!System.IO.Directory.Exists(localAppDataPath))
            {
                System.IO.Directory.CreateDirectory(localAppDataPath);
            }
            NewVersionPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData) + @"\MUIA\QDBM\newver.exe";
            CheckPage = "https://dl.dropboxusercontent.com/s/njhenmg4ufdtz81/update.html";
            RefreshCommand = new Command(Refresh);
            UpdateCommand = new Command(Update);
            Refresh();
            Status = "Idle";
        }
        #endregion
        #region Fields
        public Command RefreshCommand { get; private set; }
        public Command UpdateCommand { get; private set; }
        public string CheckPage { get; private set; }
        public string ChangelogAddress { get; private set; }
        public string NewVersionAddress { get; private set; }
        public string NewVersionPath { get; private set; }
        public string ConfigAddress { get; private set; }

        private int currentVersion;
        public int CurrentVersion
        {
            get { return currentVersion; }
            set { SetField(ref currentVersion, value); }
        }
        private int newVersion;
        public int NewVersion
        {
            get { return newVersion; }
            set { SetField(ref newVersion, value); }
        }

        private string status;
        public string Status
        {
            get { return status; }
            set { SetField(ref status, value); }
        }

        private string changelog;
        public string Changelog
        {
            get { return changelog; }
            set { SetField(ref changelog, value); }
        }

        private int pbvalue;
        public int PBValue
        {
            get { return pbvalue; }
            set { SetField(ref pbvalue, value); }
        }

        #endregion
        #region Methods
        public void Update()
        {
            if (NewVersion > CurrentVersion)
            {
                int state = 0; //To count number of files downloaded
                WebClient client = new WebClient();
                /*Dictionary<string, string> d = new Dictionary<string, string> 
                { 
                    { NewVersionAddress, NewVersionPath }, { ConfigAddress, AppDomain.CurrentDomain.BaseDirectory + "updater.config" } 
                };*/
                try
                {
                    client.DownloadFileCompleted += (sender, eventArgs) =>
                    {
                        if (state == 1)
                        {
                            Status = "Installing Update";
                            System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory + "updater.exe");
                        }
                        else
                        {
                            state++;
                            client.DownloadFileAsync(new Uri(ConfigAddress), AppDomain.CurrentDomain.BaseDirectory + "updater.config");
                        }

                    };
                    client.DownloadProgressChanged += (sender, eventArgs) =>
                    {
                        Status = "Downloading Update";
                        PBValue = eventArgs.ProgressPercentage;
                    };

                    client.DownloadFileAsync(new Uri(NewVersionAddress), NewVersionPath);

                }
                catch (Exception)
                {
                    MessageBox.Show("There was a problem connecting to the update server!");
                }

            }
            else
            {
                MessageBox.Show("Update aborted. The current version is upto date.");
                Status = "Idle";
            }
        }

        public void Refresh()
        {
            Status = "Refreshing";
            WebClient client = new WebClient();
            string webdata;
            Regex stringmods = new Regex(@"\\[a-z|A-Z|0-9]"); //ex: \n \r
            Regex tags = new Regex(@"<[a-z|A-Z|0-9|//]+>"); //ex: <center> <br>
            client.DownloadStringCompleted += (sender, eventArgs) =>
                {
                    try
                    {
                        webdata = eventArgs.Result;
                        webdata = stringmods.Replace(webdata, "");
                        webdata = tags.Replace(webdata, "");
                        //webdata structure: <ProgramName>=<VersionNo>=<NewVersionLink>=<UpdaterConfigLink>=<ChangelogLink>
                        string[] data = webdata.Split('=');

                        NewVersion = int.Parse(data[1]);
                        NewVersionAddress = data[2];
                        ConfigAddress = data[3];
                        WebClient client2 = new WebClient();
                        client2.DownloadStringCompleted += (sender2, eventArgs2) =>
                        {
                            Changelog = eventArgs2.Result;
                            Status = "Idle";
                        };
                        ChangelogAddress = data[4];
                        PBValue = 50;
                        client2.DownloadStringAsync(new Uri(ChangelogAddress));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("There was a problem connecting to the update server!");
                        Status = "Idle";
                    }

                };

            client.DownloadStringAsync(new Uri(CheckPage));
        }
        #endregion
    }
}
