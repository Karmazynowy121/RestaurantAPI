﻿using RestaurantAPI.Entitis;

namespace RestaurantAPI.Entities
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }  
        public int RestrauntId { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}