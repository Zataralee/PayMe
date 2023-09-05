using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayMe.Services
{
    public class JSONReader
    {
        public string token { get; set; }
        public string prefix { get; set; }

        public void ReadJson(string filePath)
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string json = sr.ReadToEnd();

                JSONStructure data = JsonConvert.DeserializeObject<JSONStructure>(json);

                token = data.token;
                prefix = data.prefix;
            }
        }
    }

    internal sealed class JSONStructure
    {
        public string token { get; set; }
        public string prefix { get; set; }

    }
}
