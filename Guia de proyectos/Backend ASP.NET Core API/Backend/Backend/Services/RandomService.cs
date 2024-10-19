﻿using Backend.Services;

namespace Backend.services
{
    public class RandomService : IRandomServices
    {
        private readonly int _value;
        public int Value
        {
            get => _value;
        }
        public RandomService()
        {
            _value = new Random().Next(1000);
        }
    }
}