using Newtonsoft.Json;

namespace Models
{
    public class Book
    {
        [JsonProperty("@id")]
        public string Id { get; set; }
        [JsonProperty("author")]
        public string Author { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("genre")]
        public string Genre { get; set; }
        [JsonProperty("price")]
        public string Price { get; set; }
        [JsonProperty("publish_date")]

        public string Publish_date { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }

    }
}
