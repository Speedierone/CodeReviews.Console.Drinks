﻿using Newtonsoft.Json;

namespace Drinks_List.Models
{
    public class Category
    {
        public string strCategory { get; set; }
    }

    public class Categories
    {
        [JsonProperty("drinks")]

        public List<Category> CategoriesList { get; set; }
    }
}
