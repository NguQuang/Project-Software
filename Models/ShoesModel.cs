﻿namespace Nevada.Models
{
    public class ShoesModel
    {
        public Guid Id { get; set; }
        
        public string ShoeName { get; set; }
        public float Price { get; set; }
        public string Property { get; set; }
        public int Size { get; set; }
        public bool OutOfStock { get; set; }
        public string ImageTitle { get; set; }
        public string ImageTitle1 { get; set; }
        public string ImageTitle2 { get; set; }
        public string ImageTitle3 { get; set; }
    }
}
