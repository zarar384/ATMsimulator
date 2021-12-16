using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ATMsimulator
{
    [Serializable]
    public class JsonProperties
    {
        [JsonProperty("Person")]
        public List<JsonPropertie> PersonList { get; set; } = new List<JsonPropertie>();
    }

    [Serializable]
    public class JsonPropertie
    {
        public JsonPropertie(){}
        public JsonPropertie(string name, string secondName, string numberCard, string pin, string date, decimal money)
        {
            this.name = name;
            this.secondName = secondName;
            this.numberCard = numberCard;
            this.pin = pin;
            this.date = date;
            this.money = money;
        }

        [JsonProperty("Name")]
        public string name { get; set; }
        [JsonProperty("Second name")]
        public string secondName { get; set; }
        [JsonProperty("Number card")]
        public string numberCard { get; set; }
        [JsonProperty("PIN")]
        public string pin { get; set; }
        [JsonProperty("Date")]
        public string date { get; set; }
        [JsonProperty("Money")]
        public decimal money { get; set; }
    }
}
