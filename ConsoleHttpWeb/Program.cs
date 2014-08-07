using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleHttpWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            TestHttpClient testDotNet4 = new TestHttpClient();
            TestWebClient testDotNet3 = new TestWebClient();
            TestHttpWebRequest testDotNet2 = new TestHttpWebRequest();

            Console.WriteLine();
            Console.WriteLine("Press [ENTER] to finish...");
            Console.ReadLine();
        }
    }
}
