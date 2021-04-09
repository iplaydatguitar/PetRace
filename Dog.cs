﻿using System.Numerics;

namespace PetRace
{
    class Dog : BasicPet
    {
        // this is the default speed for this pet from the original implementation.
        // this could've been done via a default parameter value in the constructor but I prefer to label my constants at the top of the file rather than lose them in the code.
        private const float DEFAULT_SPEED = 1.8f;

        // If a speed is specified then pass it along, otherwise simply send the default speed.
        public Dog(Vector2 start) : base(start, DEFAULT_SPEED) { }
        public Dog(Vector2 start, float speed) : base(start, speed) { }
    }
}