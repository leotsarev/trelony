﻿// Generated by https://quicktype.io

using Newtonsoft.Json;

namespace Joinrpg.Trelony.LegacyConsoleImporter.JsonDataModel
{
    public class GameJson
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("type")]
        [JsonConverter(typeof(GameJsonTypeConverter))]
        public GameJsonType Type { get; set; }

        [JsonProperty("polygon")]
        public string Polygon { get; set; }

        [JsonProperty("mg")]
        public string Mg { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("show_flags")]
        [JsonConverter(typeof(BoolConverter))]
        public bool ShowFlags { get; set; }

        [JsonProperty("status")]
        [JsonConverter(typeof(StatusConverter))]
        public Status Status { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("sub_region_id")]
        public int SubRegionId { get; set; }

        [JsonProperty("deleted_flag")]
        [JsonConverter(typeof(BoolConverter))]
        public bool DeletedFlag { get; set; }

        [JsonProperty("hide_email")]
        [JsonConverter(typeof(BoolConverter))]
        public bool HideEmail { get; set; }

        [JsonProperty("players_count")]
        public int? PlayersCount { get; set; }

        [JsonProperty("review_count")]
        public int ReviewCount { get; set; }

        [JsonProperty("allrpg_info_id")]
        public int? AllrpgInfoId { get; set; }

        [JsonProperty("photo_count")]
        public int? PhotoCount { get; set; }

        [JsonProperty("redirect_id")]
        public int? RedirectId { get; set; }

        [JsonProperty("vk_likes")]
        public int? VkLikes { get; set; }

        [JsonProperty("vk_club")]
        public string VkClub { get; set; }

        [JsonProperty("lj_comm")]
        public string LjComm { get; set; }

        [JsonProperty("fb_comm")]
        public string FbComm { get; set; }
    }
}
