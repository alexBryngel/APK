﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApK.Models
{
    public class personModel
    {
        public personModel()
        {
            items = new List<ItemModel>();
        }

        public int Id { get; set; }
        public string name { get; set; }
        public List<ItemModel> items { get; set; }
    }
}