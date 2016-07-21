using System;

namespace Angular3SampleApp.Services.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime MfgDate { get; set; }
        public bool IsAvailable { get; set; }
        public int CategoryId { get; set; }
        public double Price { get; set; }
    }
}