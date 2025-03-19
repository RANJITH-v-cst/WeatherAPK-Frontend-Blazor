﻿using System.Collections.Generic;

namespace ClientWeather.Models
{
    public class UserFavorites
    {
        public string Email { get; set; } = string.Empty;
        public List<string> FavoriteCities { get; set; } = new List<string>();
    }
}