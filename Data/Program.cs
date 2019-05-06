using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class RandomNumberstoCSV
{
    private const string V = "k.csv";
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
        yield return GenerateRandom(1000);
        yield return GenerateRandom(2000);
        yield return GenerateRandom(3000);
        yield return GenerateRandom(4000);
        yield return GenerateRandom(5000);
        yield return GenerateRandom(6000);
        yield return GenerateRandom(7000);
        yield return GenerateRandom(8000);
        yield return GenerateRandom(9000);
        yield return GenerateRandom(10000);
        yield return GenerateRandom(11000);
        yield return GenerateRandom(12000);
        yield return GenerateRandom(13000);
        yield return GenerateRandom(14000);
        yield return GenerateRandom(15000);
        yield return GenerateRandom(16000);
        yield return GenerateRandom(17000);
        yield return GenerateRandom(18000);
        yield return GenerateRandom(19000);
        yield return GenerateRandom(20000);
        yield return GenerateRandom(21000);
        yield return GenerateRandom(22000);
        yield return GenerateRandom(23000);
        yield return GenerateRandom(24000);
        yield return GenerateRandom(25000);
        yield return GenerateRandom(26000);
        yield return GenerateRandom(27000);
        yield return GenerateRandom(28000);
        yield return GenerateRandom(29000);
        yield return GenerateRandom(30000);
        yield return GenerateRandom(31000);
        yield return GenerateRandom(32000);
        yield return GenerateRandom(33000);
        yield return GenerateRandom(34000);
        yield return GenerateRandom(35000);
        yield return GenerateRandom(36000);
        yield return GenerateRandom(37000);
        yield return GenerateRandom(38000);
        yield return GenerateRandom(39000);
        yield return GenerateRandom(40000);
        yield return GenerateRandom(41000);
        yield return GenerateRandom(42000);
        yield return GenerateRandom(43000);
        yield return GenerateRandom(44000);
        yield return GenerateRandom(45000);
        yield return GenerateRandom(46000);
        yield return GenerateRandom(47000);
        yield return GenerateRandom(48000);
        yield return GenerateRandom(49000);
        yield return GenerateRandom(50000);
        yield return GenerateRandom(51000);
        yield return GenerateRandom(52000);
        yield return GenerateRandom(53000);
        yield return GenerateRandom(54000);
        yield return GenerateRandom(55000);
        yield return GenerateRandom(56000);
        yield return GenerateRandom(57000);
        yield return GenerateRandom(58000);
        yield return GenerateRandom(59000);
        yield return GenerateRandom(60000);
        yield return GenerateRandom(61000);
        yield return GenerateRandom(62000);
        yield return GenerateRandom(63000);
        yield return GenerateRandom(64000);
        yield return GenerateRandom(65000);
        yield return GenerateRandom(66000);
        yield return GenerateRandom(67000);
        yield return GenerateRandom(68000);
        yield return GenerateRandom(69000);
        yield return GenerateRandom(70000);
        yield return GenerateRandom(71000);
        yield return GenerateRandom(72000);
        yield return GenerateRandom(73000);
        yield return GenerateRandom(74000);
        yield return GenerateRandom(75000);
        yield return GenerateRandom(76000);
        yield return GenerateRandom(77000);
        yield return GenerateRandom(78000);
        yield return GenerateRandom(79000);
        yield return GenerateRandom(80000);
        yield return GenerateRandom(81000);
        yield return GenerateRandom(82000);
        yield return GenerateRandom(83000);
        yield return GenerateRandom(84000);
        yield return GenerateRandom(85000);
        yield return GenerateRandom(86000);
        yield return GenerateRandom(87000);
        yield return GenerateRandom(88000);
        yield return GenerateRandom(89000);
        yield return GenerateRandom(90000);
        yield return GenerateRandom(91000);
        yield return GenerateRandom(92000);
        yield return GenerateRandom(93000);
        yield return GenerateRandom(94000);
        yield return GenerateRandom(95000);
        yield return GenerateRandom(96000);
        yield return GenerateRandom(97000);
        yield return GenerateRandom(98000);
        yield return GenerateRandom(99000);
        yield return GenerateRandom(100000);
    }


    /// <summary>
    /// Run the program in the console
    /// Writes the created lists to the CSV file in the first column
    /// </summary>
    public static void Main()
    {
        int x = 0;
        string V = "k.csv";
        string Folder = "C:\\Users\\seano\\Desktop\\Test_Data\\";
        string PATH = null;
        foreach (List<int> val in Data())
        {
            PATH = Folder + (x + 1) + V;
            WriteCSV(val, PATH);
            Console.WriteLine(x + 1 + "k Completed");
            x++;
        }
        
    }
}