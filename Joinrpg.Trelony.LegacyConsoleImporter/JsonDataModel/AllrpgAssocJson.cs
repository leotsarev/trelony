﻿// Generated by https://quicktype.io

using Newtonsoft.Json;

namespace Joinrpg.Trelony.LegacyConsoleImporter.JsonDataModel
{
    public partial class AllrpgAssocJson
    {
        [JsonProperty("allrpg_zayvka_id")]
        public int AllrpgZayvkaId { get; set; }

        [JsonProperty("game_id")]
        public int? GameId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("opened")]
        [JsonConverter(typeof(BoolConverter))]
        public bool Opened { get; set; }
    }
}