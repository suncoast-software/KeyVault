using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyVault.Model
{
    internal class ConfigJson
    {
        [JsonProperty("ConnectionString")]
        public string? ConnectionString { get; set; }
    }
}
