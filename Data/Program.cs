using System;
using System.Collections.Generic;
using System.IO;

public class RandomNumberstoCSV
{
    static Random random = new Random();

    /// <summary>
    /// Generates a random list of unique numbers
    /// </summary>
    /// <param name="count"> the size of the list </param>
    /// <param name="size"> the max random value </param>
    /// <returns> A list of random, unique integers </returns>
    public static List<int> GenerateRandom(int count)
    {
        List<int> result = new List<int>();
        while (result.Count < count)
        {
            result.Add(random.Next(count * 100));
        }

        int i = result.Count;
        while (i > 1)
        {
            i--;
            int k = random.Next(i + 1);
            int value = result[k];
            result[k] = result[i];
            result[i] = value;
        }
        return result;
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
    /// All the CSV file names for every List in the Data variable
    /// </summary>
    private static List<String> DataNames = new List<String>()
    {
        "1k.csv","2k.csv","3k.csv","4k.csv","5k.csv","6k.csv","7k.csv","8k.csv","9k.csv","10k.csv",
        "11k.csv","12k.csv","13k.csv","14k.csv","15k.csv","16k.csv","17k.csv","18k.csv","19k.csv","20k.csv",
        "21k.csv","22k.csv","23k.csv","24k.csv","25k.csv","26k.csv","27k.csv","28k.csv","29k.csv","30k.csv",
        "31k.csv","32k.csv","33k.csv","34k.csv","35k.csv","36k.csv","37k.csv","38k.csv","39k.csv","40k.csv",
        "41k.csv","42k.csv","43k.csv","44k.csv","45k.csv","46k.csv","47k.csv","48k.csv","49k.csv","50k.csv",
        "51k.csv","52k.csv","53k.csv","54k.csv","55k.csv","56k.csv","57k.csv","58k.csv","59k.csv","60k.csv",
        "61k.csv","62k.csv","63k.csv","64k.csv","65k.csv","66k.csv","67k.csv","68k.csv","69k.csv","70k.csv",
        "71k.csv","72k.csv","73k.csv","74k.csv","75k.csv","76k.csv","77k.csv","78k.csv","79k.csv","80k.csv",
        "81k.csv","82k.csv","83k.csv","84k.csv","85k.csv","86k.csv","87k.csv","88k.csv","89k.csv","90k.csv",
        "91k.csv","92k.csv","93k.csv","94k.csv","95k.csv","96k.csv","97k.csv","98k.csv","99k.csv","100k.csv",
    };

    /// <summary>
    /// Run the program in the console
    /// Writes the created lists to the CSV file in the first column
    /// </summary>
    public static void Main()
    {
        int x = 0;
        foreach (List<int> val in Data())
        {
            WriteCSV(val, "C:\\Users\\seano\\Desktop\\Test_Data" + DataNames[x]);
            Console.WriteLine(DataNames[x] + " Completed");
            x++;
            Console.ReadLine();
        }
        
    }
}