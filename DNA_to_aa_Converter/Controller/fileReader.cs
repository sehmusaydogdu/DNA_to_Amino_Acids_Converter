using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DNA_to_aa_Converter.Controller
{
    class fileReader
    {
        public static List<Information> DataSource()
        {
            
            StreamReader rdr = new StreamReader("GeneticCode.txt");

            string row= "";
            List<string> array;
            List<Information> records = new List<Information>(); //Geriye dönecek olan liste
           
            while ((row=rdr.ReadLine())!=null)
            {
                array = row.Split(',').ToList();
                Information info = new Information();
                info.Key = array[0];
                array.RemoveAt(0);
                info.Values = array;
                records.Add(info);
            }
            rdr.Close();
            return records;
        }
        
    }
}
