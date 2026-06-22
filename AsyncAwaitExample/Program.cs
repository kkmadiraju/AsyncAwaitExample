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
        using HttpClient client = new HttpClient();

        string response = await client.GetStringAsync(
            "https://jsonplaceholder.typicode.com/posts/1");

        Console.WriteLine(response);
    }
}