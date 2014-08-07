using System;
using System.Collections.Generic;
using System.Linq;

using System.Net.Http; // HttpClient .NET 4.0


namespace ConsoleHttpWeb
{
    public class TestHttpClient
    {
        public TestHttpClient()
        {
            Console.WriteLine();
            Console.WriteLine("Testing HttpClient .NET 4.0");

            string requestUrl = "http://currencies.apps.grandtrunk.net/currencies";

            System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();

            HttpResponseMessage response = client.GetAsync(requestUrl).Result; // asynchronous
            string responseString = response.Content.ReadAsStringAsync().Result;

            List<string> dataList = responseString.Split('\n').ToList();
            //DropDownList1.DataSource = dataList;
            //DropDownList1.DataBind();

            int count = 0;
            foreach (string item in dataList)
            {
                Console.WriteLine(" Item {0}: {1}", ++count, item);
            }

            Console.WriteLine("Total number of items retrieved: {0} - HttpClient .NET 4.0", count);
            Console.WriteLine("Press [ENTER] ");
            Console.ReadLine();
        }
    }
}
