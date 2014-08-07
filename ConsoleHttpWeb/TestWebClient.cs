using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleHttpWeb
{
    public class TestWebClient
    {
        public TestWebClient()
        {
            Console.WriteLine();
            Console.WriteLine("Testing WebClient .NET 3.0");

            string requestUrl = "http://currencies.apps.grandtrunk.net/currencies";

            System.Net.WebClient client = new System.Net.WebClient();

            string responseString = client.DownloadString(requestUrl); // synchronous

            List<string> dataList = responseString.Split('\n').ToList();
            //DropDownList1.DataSource = dataList;
            //DropDownList1.DataBind();

            int count = 0;
            foreach(string item in dataList)
            {
                Console.WriteLine(" Item {0}: {1}", ++count, item);
            }

            Console.WriteLine("Total number of items retrieved: {0} - WebClient .NET 3.0", count);
            Console.WriteLine("Press [ENTER] ");
            Console.ReadLine();
        }
    }
}
