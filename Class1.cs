using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace IA_mate
{
    class Class1
    {
        static void Main(string[] args)
        {
            //CreateValues(1, 1, 5, 100);

            string nd = "second line";
            string g = "";
            g += "\n" + nd;
            Console.WriteLine(g);
        }
        public static void CreateValues(int correctDoors, int eliminatedDoors, int totalDoors, int repetitions)
        {
            string AllData = "";

            for (int i = 0; i < repetitions; i++)
            {

                string Line;
            }
            WriteFile(AllData, "document.txt");
        }
        public static void WriteFile(string values, string filepath)
        {
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true))
                {
                    file.WriteLine(values);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Failed this thing", ex);
            }
        }
    }
}