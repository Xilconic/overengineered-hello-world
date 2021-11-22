using System;

namespace SOLID_HelloWorld
{
    internal class RandomIntegerProvider
    {
        private readonly Random _random = new();
        
        public int GetRandomInteger(int exclusiveUpperLimit) => _random.Next(exclusiveUpperLimit);
    }
}