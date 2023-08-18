namespace drone_data_opgave_kode
{
using System.IO;
    internal class Program
    {
        static void Main(string[] args)
        {
            string readText = File.ReadAllText("flyvning1.csv");
            Console.WriteLine(readText);
            Console.ReadLine();

            String[] spearator = { ";"};
            Int32 count = int.MaxValue;

            // using the method
            String[] datalist = readText.Split(spearator, count,
                   StringSplitOptions.RemoveEmptyEntries);

            foreach (String s in datalist)
            {
                Console.WriteLine(s);
            }
        }
  
    }

}