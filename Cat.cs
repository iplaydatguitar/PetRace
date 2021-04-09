using System.Numerics;

namespace PetRace
{
    class Cat : BasicPet
    {
        // this is the default speed for this pet from the original implementation.
        // this could've been done via a default parameter value in the constructor but I prefer to label my constants at the top of the file rather than lose them in the code.
        private const float DEFAULT_SPEED = 2.0f;

        // If a speed is specified then pass it along, otherwise simply send the default speed.
        public Cat(Vector2 start) : base(start, DEFAULT_SPEED) { }
        public Cat(Vector2 start, float speed) : base(start, speed) { }
    }
}
