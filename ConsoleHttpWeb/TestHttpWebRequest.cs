using System;
using System.Collections.Generic;
using System.Linq;

using System.Net;
using System.IO;


namespace ConsoleHttpWeb
{
    public class TestHttpWebRequest
    {
        public TestHttpWebRequest()
        { 
            Console.WriteLine();
            Console.WriteLine("Testing HttpWebRequest .NET 2.0");

            string requestUrl = "http://currencies.apps.grandtrunk.net/currencies";

            HttpWebRequest httpReq = (HttpWebRequest)HttpWebRequest.Create(requestUrl);

            httpReq.Referer = "referrer";

            HttpWebResponse response = (HttpWebResponse)httpReq.GetResponse();
            using (StreamReader sr = new StreamReader(response.GetResponseStream()))
            {
                string responseString = sr.ReadToEnd();

                List<string> dataList = responseString.Split('\n').ToList();
                //DropDownList1.DataSource = dataList;
                //DropDownList1.DataBind();

                int count = 0;
                foreach(string item in dataList)
                {
                    Console.WriteLine(" Item {0}: {1}", ++count, item);
                }

                Console.WriteLine("Total number of items retrieved: {0} - HttpWebRequest .NET 2.0", count);
                Console.WriteLine("Press [ENTER] ");
                Console.ReadLine();
            }
        }
    }
}
