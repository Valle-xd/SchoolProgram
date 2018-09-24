using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace consumeRest
{
    class RestConsumer
    {
        //GET https://jsonplaceholder.typicode.com/todos
       // GET https://jsonplaceholder.typicode.com/todos/3
       // DELETE https://jsonplaceholder.typicode.com/todos/3
       // POST https://jsonplaceholder.typicode.com/todos
       // PUT https://jsonplaceholder.typicode.com/todos/3
        public void start()
        {
            Console.WriteLine("GetAll https://jsonplaceholder.typicode.com/todos");
            IList<RestData> getAll = getList("https://jsonplaceholder.typicode.com/todos");
            Console.WriteLine(getAll[0]);

        }
        private IList<RestData> getList(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                return JsonConvert.DeserializeObject<IList<RestData>>(client.GetStringAsync(url).Result);
            }
        }

        private RestData getOne(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                return JsonConvert.DeserializeObject<RestData>(client.GetStringAsync(url).Result);
            }
        }

        private bool Delete(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.DeleteAsync(url).Result;
                return response.IsSuccessStatusCode;
            }
        }

        private bool POST(RestData restData, string url)
        {
            string jSon = JsonConvert.SerializeObject(restData);
            StringContent content = new StringContent(jSon);

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.PostAsync(url, content).Result;
                return response.IsSuccessStatusCode;
            }
        }

        private bool PUT(RestData restData, string url)
        {
            string jSon = JsonConvert.SerializeObject(restData);
            StringContent content = new StringContent(jSon);

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = client.PutAsync(url, content).Result;
                return response.IsSuccessStatusCode;
            }

        }
    }
}
