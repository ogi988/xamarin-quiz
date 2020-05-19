using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Quiz.Models
{
    public partial class UserScoreList
    {
        [JsonProperty("Id")]
        public int Id { get; set; }

        [JsonProperty("Score")]
        public int Score { get; set; }

        [JsonProperty("Username")]
        public string Username { get; set; }

        
    }
}
