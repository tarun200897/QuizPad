using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPAD
{
    class OldCode
    {
        /*
                   while (qns > 0)
                   {
                       int index = rnd.Next(0, questions.Count);
                       string selected = questions[index];
                       if (!selectedIndexes.Contains(index))
                       {
                           selectedIndexes.Add(index);
                           string origOptions = "";
                           string jumbledOptions = "";

                           foreach (Match _match in optionRegex.Matches(selected))
                           {
                               origOptions = _match.ToString();

                               List<int> imageIndexes = new List<int>();
                               List<string> finalOptions = new List<string>();
                               List<string> textOptions = new List<string>();

                               foreach (Match _match2 in splitRegex1.Matches(origOptions))
                               {
                                   textOptions.Add(_match2.ToString().Replace("}", ""));
                               }


                               List<string> _temp = new List<string>(); // temporary storage list for options
                               foreach (string _textoption in textOptions)
                               {
                                   List<string> _temp2 = splitRegex2.Split(_textoption).ToList();
                                   _temp2.RemoveAt(0); // Removes {\lang....\ltrch
                                   _temp.AddRange(_temp2);
                                   imageIndexes.Add(_temp.Count - 1);
                               }

                               foreach (string _finaloption in _temp)
                               {
                                   finalOptions.Add(@"{\lang16393\ltrch <op>)" + _finaloption + "}");
                               }

                               int i = 0;
                               foreach (string _image in splitRegex1.Split(origOptions))
                               {
                                   if (_image.StartsWith(@"{\")) // To ensure it's a image
                                   {
                                       if (_image.EndsWith(@"}}}"))
                                       {
                                           finalOptions[imageIndexes[i]] = finalOptions[imageIndexes[i]] + _image;
                                       }
                                       else
                                       {
                                           finalOptions[imageIndexes[i]] = finalOptions[imageIndexes[i]] + _image + "}}"; //should end with }}}
                                       }
                                       i++;
                                   }
                               }

                               char opnum = 'a';
                               List<int> selectedOptions = new List<int>();
                               for (int opLeft = 4; opLeft > 0; )
                               {
                                   int opIndex = rnd.Next(0, finalOptions.Count);
                                   if (!selectedOptions.Contains(opIndex))
                                   {
                                       string option = finalOptions[opIndex]; //random selection
                                       jumbledOptions = jumbledOptions + option.Replace("<op>", opnum.ToString()); //adds option
                                       opLeft--; opnum++; selectedOptions.Add(opIndex);
                                   }
                               }
                               selected = selected.Replace(origOptions, jumbledOptions);
                           }

                           _selectedqns.Add(selected);
                           qns--;
                       }
                   }
                   */
    }
}
