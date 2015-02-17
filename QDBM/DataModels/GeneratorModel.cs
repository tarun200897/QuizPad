using Microsoft.Win32;
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
    class GeneratorModel : DocumentModel
    {
        #region Constructor
        public GeneratorModel()
            : base()
        {
            saveCommand = new Command(SaveDocument);
        }
        #endregion
        #region Properties
        public int Qns { get; set; }
        public bool Randomize { get; set; }

        private Command saveCommand;
        public Command SaveCommand
        { get { return saveCommand; } }
        #endregion
        #region Methods
        protected override void LoadDocument()
        {
            string filePath = "";
            FlowDocument doc = new FlowDocument();
            try
            {
                filePath = appPath + Subject + "/" + Chapter + "/" + Type + "/" + Level + ".rtf";
                doc = Document;
                String final =
                @"{\rtf1\ansi\ansicpg1252\uc1\htmautsp\deff2{\fonttbl{\f0\fcharset0 Times New Roman;}{\f2\fcharset0 Segoe UI;}{\f3\fcharset0 Calibri;}}{\colortbl\red0\green0\blue0;\red255\green255\blue255;}
                                {{{\b\ul\ltrch " + Type + @" Type - " + Level + @"}\li0\ri0\sa0\sb0\fi0\ql\par}";

                List<String> questions = new List<string>();;
                List<string> selectedQns = new List<string>();
                RTFToolkit.GetQuestions(ref questions, filePath);

                if (Randomize == true)
                {
                    Random rnd = new Random();
                    questions.Shuffle(rnd);
                    int qns = Qns > questions.Count ? questions.Count : Qns;



                    // Create a List to store selected options to 
                    // prevent duplication of qns due to jumbled options.
                    List<int> selectedIndexes = new List<int>();

                    for (int index = 0; index < qns; index++)
                    {
                        string selected = questions[index];

                        // Gets the whole block of options
                        // i.e it splits the options from the questions.
                        string origOptions = String.Concat(from Match m in RTFToolkit.QSR.Matches(selected)
                                                           select m.Value);

                        // Uses the TMR(text matching regex) to obtain only the 
                        // text from the options.
                        var matches = from Match m2 in RTFToolkit.TMR.Matches(origOptions)
                                      // Indicates presence of an image.
                                      // Will be removed later on.
                                      select (m2.Value.Replace("}", "") + "<imagehere>");

                        // Make it a list since it's iterated multiple times - faster performance.            
                        // Used to further split 'matches' into the number of options.
                        // Ex: If 4 options are present, it's split into four.
                        var finalOptions = (from string s1 in matches
                                            // Skip(1) is used to remove {\lang....\ltrch
                                            from string s2 in RTFToolkit.OSR.Split(s1).Skip(1)
                                            // <op> is the placeholder for the option as we might need to 
                                            // jumble them later on.
                                            // It is then replaced with proper alphabatically ordered 
                                            // characters.
                                            select (@"{\lang16393\ltrch <op>)" + s2 + "}")).ToList();

                        // Here the same TMR it used to obtain the images part only.
                        // i.e it splits using the TMR so that
                        // only the images remain.
                        var images = from image in RTFToolkit.TMR.Split(origOptions)
                                     // RTF indicator of an image.
                                     where image.Contains(@"\shppict")
                                     select image;

                        int count = 0;
                        for (int i = 0; i < finalOptions.Count; ++i)
                        {
                            string option = finalOptions[i];

                            // Check if image needed
                            if (option.Contains("<imagehere>"))
                            {
                                option = option.Replace("<imagehere>", "");
                                try
                                {
                                    // Loop to add necessary terminating '}'
                                    // to complete the image block.
                                    string image = images.ElementAt(count);
                                    var no = image.Count(c => c == '{') - image.Count(c => c == '}');
                                    for (int n = 0; n < no; ++n)
                                    {
                                        image += "}";
                                    }
                                    option += image;
                                }
                                catch { }

                                // Assign back as we are not operating on reference
                                finalOptions[i] = option;
                                ++count;
                            }
                        }

                        // Shuffle the options
                        finalOptions.Shuffle(rnd);

                        const int init = 'a';
                        for (char op = 'a'; op < finalOptions.Count + (int)'a'; ++op)
                        {
                            finalOptions[op - init] = finalOptions[op - init].Replace("<op>", op.ToString());
                        }
                        selected = selected.Replace(origOptions, String.Concat(finalOptions));
                        selectedQns.Add(selected);

                    }
                }
                else
                {
                    selectedQns = questions.Take(Qns).ToList();
                }

                final += String.Concat(selectedQns) + @"}}"; // "}}" ends rtf document
                using (MemoryStream mStream = new MemoryStream())
                {
                    using (StreamWriter mWriter = new StreamWriter(mStream))
                    {
                        mWriter.Write(final);
                        mWriter.Flush();
                        mStream.Position = 0;
                        var range1 = new TextRange(doc.ContentStart, doc.ContentEnd);
                        range1.Load(mStream, DataFormats.Rtf); //Loads Rtf
                    }
                }
            }
            catch { doc.Blocks.Clear(); }
        }
        private void SaveDocument()
        {
            try
            {
                SaveFileDialog dlg = new SaveFileDialog { FileName = "doc.rtf", Filter = "Rich Text Document (*.rtf)|*.rtf" };
                if (dlg.ShowDialog() == true)
                {
                    string target = dlg.FileName;
                    var _content = new TextRange(Document.ContentStart, Document.ContentEnd);
                    if (_content.CanSave(DataFormats.Rtf))
                    {
                        using (FileStream fStream = new FileStream(target, FileMode.Append, FileAccess.Write))
                        {
                            using (MemoryStream mStream = new MemoryStream())
                            {
                                _content.Save(mStream, DataFormats.Rtf);
                                mStream.WriteTo(fStream);
                                MessageBox.Show("Document has been saved.");
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Failed to save document.");
            }
        }
        #endregion
    }
}
