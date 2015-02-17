using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace QPAD
{
    class Viewmodel : BindableBase
    {   
        #region Fields
        private string _apppath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/Database/";
        #endregion
        #region Constructor
        public Viewmodel()
        {
            Database = new DatabaseModel();
            Generator = new GeneratorModel();
            Updater = new UpdaterModel(000103);
        }
        #endregion
        #region Properties
        private DatabaseModel database;
        public DatabaseModel Database
        {
            get { return database; }
            set { SetField(ref database, value); }
        }

        private GeneratorModel generator;
        public GeneratorModel Generator
        {
            get { return generator; }
            set { SetField(ref generator, value); }
        }

        private UpdaterModel updater;
        public UpdaterModel Updater
        {
            get { return updater; }
            set { SetField(ref updater, value); }
        }
        #endregion
    }
}
