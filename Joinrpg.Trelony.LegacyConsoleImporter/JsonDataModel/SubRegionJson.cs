﻿// Generated by https://quicktype.io

using Newtonsoft.Json;

namespace Joinrpg.Trelony.LegacyConsoleImporter.JsonDataModel
{
    public class SubRegionJson
    {
        [JsonProperty("sub_region_id")]
        public int SubRegionId { get; set; }

        [JsonProperty("sub_region_name")]
        public string SubRegionName { get; set; }

        [JsonProperty("sub_region_disp_name")]
        public string SubRegionDispName { get; set; }

        [JsonProperty("region_id")]
        public int RegionId { get; set; }
    }
}
