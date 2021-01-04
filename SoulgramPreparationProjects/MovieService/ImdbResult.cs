using Newtonsoft.Json;
using System.Collections.Generic;

namespace MovieService
{
    public class ImdbImage
    {
        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }
    }

    public class ImdbSerialEpisode
    {
        [JsonProperty("i")]
        public ImdbImage ScreenCapture { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("l")]
        public string ScreenCaptureDescription { get; set; }

        [JsonProperty("s")]
        public string ScreenCaptureMoment { get; set; }
    }

    public class ImdbEntity
    {
        [JsonProperty("i")]
        public ImdbImage Image { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("l")]
        public string Name { get; set; }

        [JsonProperty("q")]
        public string MediaType { get; set; } //TODO create enum for all types

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("s")]
        public string Actors { get; set; }

        [JsonProperty("v")]
        public List<ImdbSerialEpisode> SerialEpisodes { get; set; }

        [JsonProperty("y")]
        public int ReleasedYear { get; set; }

        [JsonProperty("yr")]
        public string ActiveYears { get; set; }
    }

    public class ImdbAutocompleteResponse
    {
        [JsonProperty("d")]
        public List<ImdbEntity> D { get; set; }

        [JsonProperty("q")]
        public string Query { get; set; }

        [JsonProperty("v")]
        public int ApiVersion { get; set; }
    }
}
