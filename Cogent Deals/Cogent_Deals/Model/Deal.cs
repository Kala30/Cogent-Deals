﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Cogent_Deals
{
    public class Deal
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("images")]
        public Images Images { get; set; }

        [JsonProperty("category_title")]
        public string Category { get; set; }
    }

    public class Images
    {
        [JsonProperty("image_intro")]
        public string image_intro
        {
            get { return _image_intro.Substring(23); }
            set { _image_intro = value; }
        }

        private string _image_intro;
    }
}
