using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingCompany.ConsoleUI.UI
{
    public class MenuManager
    {
        //public static void PrintOperations()
        //{
        //    for (int i = 0; i < operations.Length; i++)
        //    {
        //        Console.Write(i + 1);
        //        Console.WriteLine(" - " + operations[i] + "\t");
        //    }
        //}
        public static void PrintArrow(int index1, int index2)
        {
            if (index1 == index2)
            {
                Console.Write("-->");
            }
        }
        public static string InputString(string oldString)
        {
            string temp = "";
            temp = Console.ReadLine();
            if (temp != null && temp.Length != 0)
            {
                return temp;
            }
            else
            {
                return oldString;
            }
        }
        public static void HandleIndex(ref int chooseKey, int min, int max)
        {
            if (chooseKey < min)
            {
                chooseKey = min;
            }
            if (chooseKey >= max)
            {
                chooseKey = max;
            }
        }
    }
}
