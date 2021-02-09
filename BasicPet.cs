using System.Numerics;

namespace PetRace
{
    public enum PetType
    {
        Cat,
        Dog,
        Snake,
        Bird
    }

    class BasicPet
    {
        public BasicPet(PetType type, Vector2 start)
        {
            this.Type = type;
            this.Start = start;
        }

        protected Vector2 Start { get; private set; }
        protected PetType Type { get; private set; }

        /// return the time it takes for the pet to travel to the given location
        public float RaceTo(Vector2 loc)
        {
            switch (this.Type)
            {
                case PetType.Cat:
                case PetType.Dog:
                    return this.RunTo(loc);

                case PetType.Bird:
                    return this.FlyTo(loc);

                case PetType.Snake:
                    return this.SlitherTo(loc);

                default:
                    return 0;
            }
        }

        private float RunTo(Vector2 loc)
        {
            var speed = 0f;
            float distance = Vector2.Subtract(this.Start, loc).Length();

            if (this.Type == PetType.Dog)
            {
                speed = 1.8f;
            }
            else if (this.Type == PetType.Cat)
            {
                speed = 2.0f;
            }

            return distance / speed;
        }

        private float FlyTo(Vector2 loc)
        {
            float speed = 3.0f;
            float distance = Vector2.Subtract(this.Start, loc).Length();

            return distance / speed;
        }

        private float SlitherTo(Vector2 loc)
        {
            float speed = 0.5f;
            float distance = Vector2.Subtract(this.Start, loc).Length();

            return distance / speed;
        }
    }
}
