namespace drone_data_opgave_kode
{
using System.IO;
    internal class Program
    {
        static void Main(string[] args)
        {
            string readText = File.ReadAllText("flyvning1.csv");
            Console.WriteLine(readText);
        }
    }
}