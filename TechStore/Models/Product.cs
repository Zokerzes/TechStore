﻿using System.Diagnostics.Metrics;

namespace TechStore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MakerId { get; set; }
        public Maker? Maker { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
    }
}
