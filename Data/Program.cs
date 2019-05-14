using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class RandomNumberstoCSV
{
    static Random random = new Random();

    /// <summary>
    /// Generates a random list of unique integers (no duplicates)
    /// </summary>
    /// <param name="count"> the size of the list </param>
    /// <param name="size"> the max random value </param>
    /// <returns> A list of integers </returns>
    public static List<int> GenerateRandom(int count)
    {
        HashSet<int> result = new HashSet<int>();
        while (result.Count < count)
        {
            result.Add(random.Next(count * 100));
        }

        List<int> output = result.ToList();
        return output;
    }

    /// <summary>
    /// Creates the CSV file with an integer list and the path being put into 
    /// </summary>
    /// <param name="array"></param>
    /// <param name="path"></param>
    private static void WriteCSV(List<int> array, string path)
    {
        using (var writer = new StreamWriter(path))
        {
            foreach (int item in array)
            {
                writer.WriteLine(string.Join(", ", item));
            }
        }
    }

    /// <summary>
    /// Sets up all the data sets into an IEnumerable object
    /// </summary>
    private static IEnumerable<List<int>> Data()
    {
        yield return GenerateRandom(100);
        yield return GenerateRandom(200);
        yield return GenerateRandom(300);
        yield return GenerateRandom(400);
        yield return GenerateRandom(500);
        yield return GenerateRandom(600);
        yield return GenerateRandom(700);
        yield return GenerateRandom(800);
        yield return GenerateRandom(900);
        yield return GenerateRandom(1000);
        yield return GenerateRandom(1100);
        yield return GenerateRandom(1200);
        yield return GenerateRandom(1300);
        yield return GenerateRandom(1400);
        yield return GenerateRandom(1500);
        yield return GenerateRandom(1600);
        yield return GenerateRandom(1700);
        yield return GenerateRandom(1800);
        yield return GenerateRandom(1900);
        yield return GenerateRandom(2000);
        yield return GenerateRandom(2100);
        yield return GenerateRandom(2200);
        yield return GenerateRandom(2300);
        yield return GenerateRandom(2400);
        yield return GenerateRandom(2500);
        yield return GenerateRandom(2600);
        yield return GenerateRandom(2700);
        yield return GenerateRandom(2800);
        yield return GenerateRandom(2900);
        yield return GenerateRandom(3000);
        yield return GenerateRandom(3100);
        yield return GenerateRandom(3200);
        yield return GenerateRandom(3300);
        yield return GenerateRandom(3400);
        yield return GenerateRandom(3500);
        yield return GenerateRandom(3600);
        yield return GenerateRandom(3700);
        yield return GenerateRandom(3800);
        yield return GenerateRandom(3900);
        yield return GenerateRandom(4000);
        yield return GenerateRandom(4100);
        yield return GenerateRandom(4200);
        yield return GenerateRandom(4300);
        yield return GenerateRandom(4400);
        yield return GenerateRandom(4500);
        yield return GenerateRandom(4600);
        yield return GenerateRandom(4700);
        yield return GenerateRandom(4800);
        yield return GenerateRandom(4900);
        yield return GenerateRandom(5000);
        yield return GenerateRandom(5100);
        yield return GenerateRandom(5200);
        yield return GenerateRandom(5300);
        yield return GenerateRandom(5400);
        yield return GenerateRandom(5500);
        yield return GenerateRandom(5600);
        yield return GenerateRandom(5700);
        yield return GenerateRandom(5800);
        yield return GenerateRandom(5900);
        yield return GenerateRandom(6000);
        yield return GenerateRandom(6100);
        yield return GenerateRandom(6200);
        yield return GenerateRandom(6300);
        yield return GenerateRandom(6400);
        yield return GenerateRandom(6500);
        yield return GenerateRandom(6600);
        yield return GenerateRandom(6700);
        yield return GenerateRandom(6800);
        yield return GenerateRandom(6900);
        yield return GenerateRandom(7000);
        yield return GenerateRandom(7100);
        yield return GenerateRandom(7200);
        yield return GenerateRandom(7300);
        yield return GenerateRandom(7400);
        yield return GenerateRandom(7500);
        yield return GenerateRandom(7600);
        yield return GenerateRandom(7700);
        yield return GenerateRandom(7800);
        yield return GenerateRandom(7900);
        yield return GenerateRandom(8000);
        yield return GenerateRandom(8100);
        yield return GenerateRandom(8200);
        yield return GenerateRandom(8300);
        yield return GenerateRandom(8400);
        yield return GenerateRandom(8500);
        yield return GenerateRandom(8600);
        yield return GenerateRandom(8700);
        yield return GenerateRandom(8800);
        yield return GenerateRandom(8900);
        yield return GenerateRandom(9000);
        yield return GenerateRandom(9100);
        yield return GenerateRandom(9200);
        yield return GenerateRandom(9300);
        yield return GenerateRandom(9400);
        yield return GenerateRandom(9500);
        yield return GenerateRandom(9600);
        yield return GenerateRandom(9700);
        yield return GenerateRandom(9800);
        yield return GenerateRandom(9900);
        yield return GenerateRandom(10000);
    }


    /// <summary>
    /// Run the program in the console
    /// Writes the created lists to the CSV file in the first column
    /// </summary>
    public static void Main()
    {
        int x = 0;
        string V = ".csv";
        string Folder = "C:\\Users\\seano\\Desktop\\Test_Data\\";
        string PATH = null;
        foreach (List<int> val in Data())
        {
            PATH = Folder + (x + 1) + V;
            WriteCSV(val, PATH);
            Console.WriteLine(x + 1 + "00 Completed");
            x++;
        }
        
    }
}