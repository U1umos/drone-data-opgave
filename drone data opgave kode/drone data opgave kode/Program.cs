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

            string[] longData = new string[datalist.Length];
            for(int i = 17; i<datalist.Length;i=i+13)
            {
                string BrokenLongData = datalist[i];
                BrokenLongData = BrokenLongData.Replace(".", string.Empty);
                /*Console.WriteLine(BrokenLongData.Replace(".", string.Empty));
                Console.WriteLine(i / 13);
                Console.WriteLine(BrokenLongData.Insert(1,"."));*/
                BrokenLongData = BrokenLongData.Insert(2, ".");
                longData[i] = BrokenLongData;                
            }
            string[] latData = new string[datalist.Length];
            for (int i = 18; i < datalist.Length; i=i+13)
            {
                string BrokenLatData = datalist[i];
                BrokenLatData = BrokenLatData.Replace(".", string.Empty);
               /* Console.WriteLine(BrokenLatData.Replace(".",string.Empty));
                Console.WriteLine(i / 13);
                Console.WriteLine(BrokenLatData);
                Console.WriteLine(BrokenLatData.Insert(2, "."));*/
                BrokenLatData = BrokenLatData.Insert(2, ".");
                latData[i] = BrokenLatData;
            }
            string line = "";
            for (int i = 0; i < datalist.Length; i++)
            {
                line = datalist[i] + datalist[i+1] + datalist[i + 2] + datalist[i + 3] + datalist[i + 4] + datalist[i + 5] + datalist[i + 6] + datalist[i + 7] + datalist[i + 8] + datalist[i + 9] + datalist[i + 10] + datalist[i + 11] + datalist[i + 12] + "GPSKoord";
                // Console.WriteLine(datalist[i]);
                File.AppendAllText("sorted.csv", datalist[i] + "\n");
            }
        }
    }
}