using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Utility
    {
        private static string _filepath1 = "Price.txt";
        private static string _filePath = "Zoo.txt";
        public static string WriteToText(string data)
        {
            if (!File.Exists(_filePath));
            {
                using (File.Create(_filePath));
            }
            using (StreamWriter outputFile = new StreamWriter(_filePath))
            {
                outputFile.WriteLine(data);
            }
            return "sucess";
        }

        //internal static string ReadFromFile => throw new NotImplementedException();


        public static string ReadFromFile()
        {
            if (File.Exists(_filePath))
            {
                string data = File.ReadAllText(_filePath);
                return data;
            }
            return null;
        }

        public static string WriteTicketPrice(String data)
        {

            if (!File.Exists(_filepath1))
            {
                File.Create(_filepath1);
            }

            using (StreamWriter outputFile = new StreamWriter(_filepath1))
            {
                outputFile.WriteLine(data);

            }



            return "success";







        }
        public static string ReadPriceFromFile()
        {
            if (File.Exists(_filepath1))
            {
                string data = File.ReadAllText(_filepath1);
                return data;
            }
            return null;
        }

    }
}
