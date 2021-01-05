using Newtonsoft.Json;
using System.Collections.Generic;

namespace MovieService
{
    public class Videocdn
    {
        [JsonProperty("url")]
        public List<string> Url { get; set; }

        [JsonProperty("quality")]
        public List<string> Quality { get; set; }

        [JsonProperty("duration")]
        public object Duration { get; set; }

        [JsonProperty("voice")]
        public List<string> Voice { get; set; }
    }

    public class Hdvb
    {
        [JsonProperty("url")]
        public object Url { get; set; }

        [JsonProperty("quality")]
        public object Quality { get; set; }

        [JsonProperty("duration")]
        public object Duration { get; set; }

        [JsonProperty("voice")]
        public object Voice { get; set; }
    }

    public class Collapse
    {
        [JsonProperty("url")]
        public List<string> Url { get; set; }

        [JsonProperty("quality")]
        public List<string> Quality { get; set; }

        [JsonProperty("duration")]
        public List<string> Duration { get; set; }

        [JsonProperty("voice")]
        public List<string> Voice { get; set; }
    }

    public class Kodik
    {
        [JsonProperty("url")]
        public object Url { get; set; }

        [JsonProperty("quality")]
        public object Quality { get; set; }

        [JsonProperty("duration")]
        public object Duration { get; set; }

        [JsonProperty("voice")]
        public object Voice { get; set; }
    }

    public class KinopoiskResult
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("id_kinopoisk")]
        public int IdKinopoisk { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("title_alternative")]
        public string TitleAlternative { get; set; }

        [JsonProperty("tagline")]
        public string Tagline { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("poster")]
        public string Poster { get; set; }

        [JsonProperty("trailer")]
        public string Trailer { get; set; }

        [JsonProperty("age")]
        public string Age { get; set; }

        [JsonProperty("actors")]
        public List<string> Actors { get; set; }

        [JsonProperty("countries")]
        public List<string> Countries { get; set; }

        [JsonProperty("genres")]
        public List<string> Genres { get; set; }

        [JsonProperty("directors")]
        public List<string> Directors { get; set; }

        [JsonProperty("screenwriters")]
        public List<string> Screenwriters { get; set; }

        [JsonProperty("producers")]
        public List<string> Producers { get; set; }

        [JsonProperty("operators")]
        public List<string> Operators { get; set; }

        [JsonProperty("composers")]
        public List<string> Composers { get; set; }

        [JsonProperty("painters")]
        public List<string> Painters { get; set; }

        [JsonProperty("editors")]
        public List<string> Editors { get; set; }

        [JsonProperty("budget")]
        public object Budget { get; set; }

        [JsonProperty("rating_kinopoisk")]
        public double RatingKinopoisk { get; set; }

        [JsonProperty("rating_imdb")]
        public double RatingImdb { get; set; }

        [JsonProperty("kinopoisk_votes")]
        public object KinopoiskVotes { get; set; }

        [JsonProperty("imdb_votes")]
        public object ImdbVotes { get; set; }

        [JsonProperty("fees_world")]
        public string FeesWorld { get; set; }

        [JsonProperty("fees_russia")]
        public object FeesRussia { get; set; }

        [JsonProperty("premiere_world")]
        public string PremiereWorld { get; set; }

        [JsonProperty("premiere_russia")]
        public string PremiereRussia { get; set; }

        [JsonProperty("frames")]
        public List<string> Frames { get; set; }

        [JsonProperty("screenshots")]
        public object Screenshots { get; set; }

        [JsonProperty("videocdn")]
        public Videocdn Videocdn { get; set; }

        [JsonProperty("hdvb")]
        public Hdvb Hdvb { get; set; }

        [JsonProperty("collapse")]
        public Collapse Collapse { get; set; }

        [JsonProperty("kodik")]
        public Kodik Kodik { get; set; }
    }
}
