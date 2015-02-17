using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QPAD
{
    static class RTFToolkit
    {
        
        /// <summary>
        /// Question Splitting Regex.
        /// Matches with the options part from the questions
        /// </summary>
        static public Regex QSR = new Regex(@"\{\\[a-z|A-Z|0-9|\\]+\s+\(?[a|A]\).*[b|B]\).*[c|C]\).*[d|D].*?\}", RegexOptions.Singleline);

        /// <summary>
        /// Text Matching Regex.
        /// </summary>
        static public Regex TMR = new Regex(@"\{\\[a-z|A-Z|0-9|\\]+\s+\(?[a-d|A-D]\).*?\}", RegexOptions.Singleline);


        /// <summary>
        /// Option Splitting Regex.
        /// Gets options. ex: "a)"
        /// </summary>
        static public Regex OSR = new Regex(@"\(?[a-d|A-D]\)", RegexOptions.Singleline);

        public static void GetQuestions(ref List<String> questions,string filePath)
        {
            StreamReader reader = new StreamReader(filePath);

            Boolean started = false;
            Regex questionrgx = new Regex(@"\{\\pntext.* \d+\.\\tab\}");

            String currentquestion = "";
            String line;
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                if (questionrgx.IsMatch(line))
                {
                    if (currentquestion != "")
                    {
                        questions.Add(currentquestion);
                    }
                    currentquestion = questionrgx.Replace(line, "");
                    started = true;
                }

                // Check for "}" is to ensure it's not end of document
                else if (started & (line != "}"))
                {
                    currentquestion = string.Concat(currentquestion, Environment.NewLine, line);
                }
            }

            // Adds the final question
            questions.Add(currentquestion);
        }

        public static String ImageTag(int i)
        {
            return "<image-" + i.ToString() + ">";
        }
    }
}
