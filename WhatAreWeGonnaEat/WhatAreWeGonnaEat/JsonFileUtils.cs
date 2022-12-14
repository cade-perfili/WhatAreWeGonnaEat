using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WhatAreWeGonnaEat;


namespace WhatAreWeGonnaEat
{
    //Newtonsoft/JsonFileUtils.cs
    public static class JsonFileUtils
    {
        private static readonly JsonSerializerSettings _options
            = new() { NullValueHandling = NullValueHandling.Ignore };

        public static void PrettyWrite(object obj, string fileName)
        {
            var jsonString = JsonConvert.SerializeObject(obj, Formatting.Indented, _options);

            File.WriteAllText(fileName, jsonString);
        }

        public static void DeSimpleWrite(object List, string fileName)
        {
           // var jsonlist = JsonConvert.DeserializeObject<List>;
          //  File.WriteAllText(fileName, jsonlist);
        }
    }
}