using System;
using System.Threading.Tasks;

class Program1
{
    //Is async only associated with Task
    //No, async can be used with other types as well,
    //such as ValueTask and IAsyncEnumerable.
    //However, Task is the most commonly used type
    //for asynchronous operations in C#.
    static async Task Main1()
    {
        Console.WriteLine("Before calling method");

        //When you call an async method,
        //you typically use the await keyword to wait for the result.
        string result = await GetDataAsync();

        Console.WriteLine(result);
        Console.WriteLine("After calling method");
    }

    static async Task<string> GetDataAsync()
    {
        Console.WriteLine("Fetching data...");

        // Simulate a 2-second asynchronous operation

        //Is Task equals Thread
        //No, Task and Thread are different concepts in C#.
        await Task.Delay(2000);

        return "Data fetched successfully!";
    }
}