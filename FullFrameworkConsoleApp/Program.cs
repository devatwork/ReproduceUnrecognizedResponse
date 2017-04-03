using System;
using System.Net.Http;

namespace FullFrameworkConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
			for (var i = 0; i < 10000; i++)
			{
				using (var httpClient = new HttpClient())
				{
					var request = new HttpRequestMessage(HttpMethod.Head, new Uri("http://127.0.0.1:5000"));
					var response = httpClient.SendAsync(request).Result;
				}
			}
		}
    }
}
