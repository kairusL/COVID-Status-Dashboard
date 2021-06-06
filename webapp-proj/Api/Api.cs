using unirest_net.http;
using System.Xml;
using System.Net.Http;
using System;

namespace webapp_proj
{
    public class Api
    {
        public async System.Threading.Tasks.Task ApiCallAsync()
    {
     var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://covid-19-coronavirus-statistics.p.rapidapi.com/v1/total?country=Canada"),
                Headers =
    {
        { "x-rapidapi-key", "c00a4a90b3mshd32227aa8a9e2c8p13f9ecjsn5cdd7e795a7c" },
        { "x-rapidapi-host", "covid-19-coronavirus-statistics.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(body.ToString());
                Console.WriteLine(doc.DocumentElement.FirstChild.InnerText);
 
                foreach(XmlNode node in doc.DocumentElement.ChildNodes){
                Console.WriteLine(node.InnerText);    }
            }


    }


}       

}