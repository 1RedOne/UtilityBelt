﻿using System.Text.Json.Serialization;

namespace UtilityBelt.Models
{
    public class AdviceModel
    {
        [JsonPropertyName("slip")]
        public SlipModel Slip { get; set; }
    }

    public class SlipModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("advice")]
        public string Advice { get; set; }
    }
}
