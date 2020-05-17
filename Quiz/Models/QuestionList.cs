using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class QuestionList
    {
        [JsonProperty("Id")]
        public long Id { get; set; }

        [JsonProperty("Text")]
        public string Text { get; set; }

        [JsonProperty("CorrectAnswer")]
        public string CorrectAnswer { get; set; }

        [JsonProperty("Answer1")]
        public string Answer1 { get; set; }

        [JsonProperty("Answer2")]
        public string Answer2 { get; set; }

        [JsonProperty("Answer3")]
        public string Answer3 { get; set; }

        [JsonProperty("Difficulty")]
        public long Difficulty { get; set; }
    }

}
