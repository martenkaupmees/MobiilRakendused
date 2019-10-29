using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ListExercise.Core.Oige
{
    public class DataService
    {
        public static async Task<dynamic> GetDataFromPeople(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(queryString);

            People data = null;
            if (response != null)
            {
                data = JsonConvert.DeserializeObject<People>(response);
            }
            return data;
        }
    }
}

