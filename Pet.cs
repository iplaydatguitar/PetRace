using System.Numerics;

namespace PetRace
{
    public enum PetType
    {
        Cat,
        Dog,
        Snake,
        Bird,
        Fish
    }

    /* 
    * It would be far better to make this abstract and instead create pet specific classes that inherit from BasicPet.
    * That would eliminate the annoying switch and if statements that are difficult to maintain and harm readability.
    * You could then have a move() function (or similar) that does the pet specific math. More on this later.
    */
    class BasicPet
    {
        public BasicPet(PetType type, Vector2 start)
        {
            this.Type = type;
            this.Start = start;
        }

        // As the code currently stands, there's no reason why these couldn't simply be private member variables.
        // If you were to make the class abstract and derive pet specific classes then this makes more sense.
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

                // Theoretically, couldn't a bird both fly or run? It would be very slow at running but this should be considered.
                // Assuming this is refactored later, you could add a preferred movement option as a parameter to RaceTo() or an inherited move() function.
                case PetType.Bird:
                    return this.FlyTo(loc);

                case PetType.Snake:
                    return this.SlitherTo(loc);

                // we're already making this switch statement longer and duplicating more code and it will continue to get longer for every PetType we add. This is not good.
                case PetType.Fish:
                    return this.SwimTo(loc);

                default:
                    return 0;
            }
        }

        /*
         * RunTo(), FlyTo(), and SlitherTo() are dying for a refactor. They're essentially identical in logic the only difference being the speeds. I see
         * 3 possible options:
         * 
         * 1. You could instead do a GetSpeed(PetType type) function to get the speed variables and then combine the functions. 
         * 
         * However, speed is always constant and specific to each pet type. So,
         * 
         * 2. You could make this class abstract, make pet specific inherited classes, and make speed a const variable in each class. 
         * or
         * 3. You could do the inheritance previously described and make speed a readonly member variable and allow each instance of each pet to have 
         * differing speeds since not all animals move at exactly the same rate even if they're the same type (e.g. chihuahua vs greyhound).
         * You can still use these existing numbers as defaults.
         * 
         * Note that options 2 and 3 don't require the inherited classes since you can add them in this existing class but it makes more sense to me to do it that way.
         */
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

            // If RunTo() were called with a Type other than Dog or Cat than you could get a division by 0 exception.
            // I suppose you could add and else block and return -1 or 0 and log the issue (or throw an exception) but I prefer one of my solutions listed above.
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

        /*
         * This is identical to the previous 3 movement functions (RunTo, FlyTo, SlitherTo) and if there ever needs to be a change then
         * We have to make sure we remember to change all of them together. Inevitably someday something will be missed and this will cause bugs.
         * Ideally, these functions would be refactored as described in exercise 1. I assume this is not requested in exercise 2 so I didn't do any refactor.
         * Something else to think about is that we're only using 2 coordinates. In a real world scenario, we would need to use 3 axis x,y,z.
         */
        private float SwimTo(Vector2 loc)
        {
            float speed = 1.2f; // I just guessed on a value that seemed to make sense. A refactor of these values was not explicitly requested so I didn't perform one.
            float distance = Vector2.Subtract(this.Start, loc).Length();

            return distance / speed;
        }
    }
}
