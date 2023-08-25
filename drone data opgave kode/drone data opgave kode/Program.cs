namespace drone_data_opgave_kode
{
using System.IO;
    internal class Program
    {
        static void Main(string[] args)
        {
            File.Delete("Sorted.csv");
            string readText = File.ReadAllText("flyvning1.csv");
            Console.WriteLine(readText);
            Console.ReadLine();

            String[] spearator = { ";","\n"};
            Int32 count = int.MaxValue;

            // using the method
            String[] datalist = readText.Split(spearator, count,
                   StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i<datalist.Length; i++)
            {
                Console.WriteLine(datalist[i]);
                File.AppendAllText("sorted.csv", datalist[i] + "\n");
            }

            string[] longData = new string[datalist.Length];
            for(int i = 17; i<datalist.Length;i++)
            {
                string BrokenLongData = datalist[i];
                Console.WriteLine(BrokenLongData);
                i = (i + 12);
                break;
            }
        }
    }
}