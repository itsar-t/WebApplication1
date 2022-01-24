﻿using MongoDB.Bson;

namespace WebApplication1.Models
{
    public class Order
    {
        public ObjectId Id { get; set; }
        public int Amount { get; set; }
        public string Food { get; set; } 
    }
}
