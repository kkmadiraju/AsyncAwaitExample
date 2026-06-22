//using System;
//using System.Collections.Generic;
//using System.Dynamic;
//using System.Text;

//namespace AsyncAwaitExample
//{
//    internal class RealworldexampleCallingaWebAPI
//    {
//    }
//}
using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        //using HttpClient client = new HttpClient();

        //string response = await client.GetStringAsync(
        //    "https://jsonplaceholder.typicode.com/posts/1");



        //Console.WriteLine(response);
        //Example of multiple awaits in a single method

        //I called the method ProcessAsync in routine way, which didn't work
        //So addded await keyword to make it working
        await ProcessAsync();

        await RunTasksInParalell();
    }
    //Multiple awaits in the same method
    //One Async can have multiple await statements in the same method. Each await statement will pause the execution of the method until the awaited task completes,
    //allowing other tasks to run in the meantime.
    static async Task ProcessAsync()
    {
        Console.WriteLine("Step 1");
        await Task.Delay(1000);

        Console.WriteLine("Step 2");
        await Task.Delay(1000);

        Console.WriteLine("Step 3");
    }
    static async Task RunTasksInParalell()
    {
        Task task1 = Task.Delay(2000);
        Task task2 = Task.Delay(3000);

        await Task.WhenAll(task1, task2);

        Console.WriteLine("Both tasks completed.");
    }

    }