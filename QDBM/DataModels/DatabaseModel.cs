using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace QPAD
{
    class DatabaseModel : DocumentModel
    {
        #region Properties

        private Command updateCommand;
        public Command UpdateCommand
        {
            get { return updateCommand; }
        }
        public bool Backup { get; set; }
        #endregion
        #region Constructor
        public DatabaseModel()
            : base()
        {
            updateCommand = new Command(UpdateDatabase);
        }
        #endregion
        #region Methods
        protected override void LoadDocument()
        {
            string filePath = appPath + Subject + "/" + Chapter + "/" + Type + "/" + Level + ".rtf";
            if (File.Exists(filePath))
            {
                var range = new TextRange(Document.ContentStart, Document.ContentEnd);

                using (FileStream fStream = new System.IO.FileStream(filePath, System.IO.FileMode.Open))
                {
                    range.Load(fStream, System.Windows.DataFormats.Rtf);
                    return;
                }
            }
            Document.Blocks.Clear();
        }
        private void UpdateDatabase()
        {
            string targetdir = appPath + Subject + "/" + Chapter + "/" + Type + "/";
            string fileName = Level + ".rtf";
            string backup = "";
            var content = new TextRange(Document.ContentStart, Document.ContentEnd);

            if (!Directory.Exists(targetdir))
            {
                Directory.CreateDirectory(targetdir);
            }
            if (File.Exists(targetdir + fileName))
            {
                if (Backup)
                {
                    int i = 0;
                    foreach (String file in Directory.GetFiles(targetdir, Level + "_backup*.rtf"))
                    {
                        i++;
                    }
                    File.Move(targetdir + fileName, targetdir + Level + "_backup" + i + ".rtf");
                    backup = " Backup of previous version created.";
                }
                else
                {
                    File.Delete(targetdir + fileName);
                    backup = "";
                }
            }
            if (content.CanSave(DataFormats.Rtf))
            {
                using (FileStream fs = new FileStream(targetdir + fileName, FileMode.Append, FileAccess.Write))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        content.Save(ms, DataFormats.Rtf);
                        ms.Seek(0, SeekOrigin.Begin);
                        var sr = new StreamReader(ms, Encoding.ASCII);
                        String docrtf = sr.ReadToEnd();
                        var images = from image in RTFToolkit.TMR.Split(docrtf).Skip(1)
                                     select image;
                        // Need to think about how to remove duplication of images here.
                        for (int i = 0; i < images.Count(); ++i)
                        {
                            string image = images.ElementAt(i);
                            docrtf.Replace(image,RTFToolkit.ImageTag(i));                            
                        }
                        File.WriteAllText("j:/test.txt", docrtf);

                        string imgPath = "j:/images.txt";
                        File.Delete(imgPath);
                        foreach (string image in images)
                        {
                            File.AppendAllText(imgPath,Environment.NewLine);
                            File.AppendAllText("j:/images.txt", image);
                        }

                        ms.Seek(0, SeekOrigin.Begin);
                        ms.WriteTo(fs);
                        MessageBox.Show("Database has been updated." + backup);
                    }
                }
            }
            else
            {
                MessageBox.Show("Failed to save.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            SubjectRefresh(Subjects);
        }
        #endregion
    }
}
