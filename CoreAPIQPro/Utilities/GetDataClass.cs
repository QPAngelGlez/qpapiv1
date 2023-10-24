using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using CoreAPIQPro.Models;

namespace CoreAPIQPro.Utilities
{
    public class GetDataClass
    {
        public List<Contact> GetContactsFile(string fileNme)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "JsonResponses/"+ fileNme);
            if (File.Exists(filePath))
            {
                using (StreamReader r = new StreamReader(filePath))
                {
                    string jsonString = r.ReadToEnd(); List<Contact> response = JsonConvert.DeserializeObject<List<Contact>>(jsonString);
                    return response;
                }
            }
            else
            {
                return new List<Contact>();
            }
        }
    }
}
