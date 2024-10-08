﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace recipeApp2
{
    [JsonObject]
    public class favorite_tableList
    {
        [JsonProperty("List")]
        public List<favorite_tableRow> List { get; set; } = new List<favorite_tableRow>();
    }

    [JsonObject]
    public class favorite_tableRow
    {
        [JsonProperty("favorite_id")]
        public int favorite_id { get; set; }

        [JsonProperty("user_id")]
        public int user_id { get; set; }

        [JsonProperty("recipe_id")]
        public int recipe_id { get; set; }


    }

    [JsonObject]
    public class favoriteall_tableList
    {
        [JsonProperty("List")]
        public List<favoriteall_tableRow> List { get; set; } = new List<favoriteall_tableRow>();
    }

    [JsonObject]
    public class favoriteall_tableRow
    {
        [JsonProperty("favorite_id")]
        public int favorite_id { get; set; }

        [JsonProperty("user_id")]
        public int user_id { get; set; }

        [JsonProperty("recipe_id")]
        public int recipe_id { get; set; }


    }


    [JsonObject]
    public class favoriteif_tableList
    {
        [JsonProperty("List")]
        public List<favoriteif_tableRow> List { get; set; } = new List<favoriteif_tableRow>();
    }

    [JsonObject]
    public class favoriteif_tableRow
    {
        [JsonProperty("favorite_id")]
        public int favorite_id { get; set; }

        [JsonProperty("user_id")]
        public int user_id { get; set; }

        [JsonProperty("recipe_id")]
        public int recipe_id { get; set; }
    }

}
