using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;

namespace QPAD
{
    class DocumentModel : BindableBase
    {
        #region Fields
        protected static string appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/Database/";
        #endregion
        #region Properties
        public ObservableCollection<ComboBoxItem> Subjects { get; set; }
        public ObservableCollection<ComboBoxItem> Chapters { get; set; }

        private Command loadCommand;
        public Command LoadCommand
        {
            get { return loadCommand; }
        }
        FlowDocument document;
        public FlowDocument Document
        {
            get { return document; }
            set { SetField(ref document, value); }
        }

        private string subject;
        public string Subject
        {
            get { return subject; }
            set { if (SetField(ref subject, value)) ChapterRefresh(); }
        }

        private string chapter;
        public string Chapter
        {
            get { return chapter; }
            set { SetField(ref chapter, value); }
        }

        private string level;
        public string Level
        {
            get { return level; }
            set { SetField(ref level, value); }
        }

        private string type;
        public string Type
        {
            get { return type; }
            set { SetField(ref type, value); }
        }
        #endregion
        #region Constructor
        public DocumentModel()
        {
            loadCommand = new Command(LoadDocument);
            Subjects = new ObservableCollection<ComboBoxItem>();
            Chapters = new ObservableCollection<ComboBoxItem>();
            Document = new FlowDocument();
            SubjectRefresh(Subjects);
        }
        #endregion
        #region Methods
        protected virtual void LoadDocument()
        {

        }
        protected void SubjectRefresh(ObservableCollection<ComboBoxItem> Subjects)
        {
            if (!Directory.Exists(appPath))
            {
                Directory.CreateDirectory(appPath);
            }
            Subjects.Clear();

            foreach (string d1 in Directory.GetDirectories(appPath))
            {
                Subjects.Add(new ComboBoxItem { Content = System.IO.Path.GetFileName(d1) });
            }
            Subjects.Add(new ComboBoxItem { Content = "New Subject" });
            ComboBoxItem first = Subjects.FirstOrDefault();
            first.IsSelected = true;

        }
        protected void ChapterRefresh()
        {
            Chapters.Clear();
            try
            {
                foreach (string d1 in Directory.GetDirectories(appPath + Subject + "/"))
                {
                    Chapters.Add(new ComboBoxItem { Content = System.IO.Path.GetFileName(d1) });
                }
            }
            catch 
            { }
            finally
            {
                Chapters.Add(new ComboBoxItem { Content = "New Chapter" });
                ComboBoxItem first = Chapters.FirstOrDefault();
                first.IsSelected = true;
            }
        }
        #endregion
    }
}
