using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QPAD
{
    public static class Extensions
    {
        /// <summary>
        /// Does a Fisher-Yates shuffle on the List
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">List to be shuffled</param>
        /// <param name="rnd"></param>
        public static void Shuffle<T>(this IList<T> list, Random rnd)
        {
            for (var i = 0; i < list.Count; i++)
            {
                int rand = rnd.Next(i, list.Count);
                //T a = list[i]; T b = list[rand];
                //Swap(ref a,ref b);
                //list[i] = a; list[rand] = b;
          
                list.Swap(i, rand);
            }
        }

        /// <summary>
        /// Swaps two objects
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="a">Calling object</param>
        /// <param name="b">Object to be swapped with</param>
        public static void Swap<T>(this T a,ref T b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// Swaps two children of a List
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="i">First child's index</param>
        /// <param name="j">Second child's index</param>
        public static void Swap<T>(this IList<T> list,int i,int j){
            var temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }

    }
}