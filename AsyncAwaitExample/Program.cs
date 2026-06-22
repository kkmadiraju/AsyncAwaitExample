using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Before calling method");

        string result = await GetDataAsync();

        Console.WriteLine(result);
        Console.WriteLine("After calling method");
    }

    static async Task<string> GetDataAsync()
    {
        Console.WriteLine("Fetching data...");

        // Simulate a 2-second asynchronous operation
        await Task.Delay(2000);

        return "Data fetched successfully!";
    }
}