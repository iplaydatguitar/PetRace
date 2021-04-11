using System;
using System.Numerics;

namespace PetRace
{
    /*
     * This alternative refactor changes BasicPet to a generic class, declares a new IPet interface to get the default speed, and changes the pet specific classes
     * to now only care about returning the default speed. The default speed is now stored in the App.config settings so that they can be changed without modifying
     * the code.
     */
    class BasicPet<T> where T : IPet, new()
    {
        private readonly float _movementSpeed = 1f; // speed is now a readonly member variable so it can be customized at object creation if desired.
        private Vector2 _start; // the start value is only ever used or set within this class. Just make it a private member variable.

        public BasicPet(Vector2 start) : this(start, new T().GetDefaultSpeed()) { }

        public BasicPet(Vector2 start, float speed)
        {
            _start = start;
            
            // it doesn't make sense for a pet to have a 0 or negative speed. That could result in a bad race or possible infinite loop depending
            // on how the data is used.
            if (speed > 0)
                _movementSpeed = speed;
            else
                throw new ArgumentOutOfRangeException("speed", speed, "Pet speed must be greater than 0!"); // it's better to throw a useful customized exception rather than fail silently or revert to a default.
        }

        /// return the time it takes for the pet to travel to the given location
        public float RaceTo(Vector2 loc)
        {
            float distance = Vector2.Subtract(_start, loc).Length();
            // FYI - I realized in my testing that dividing by zero on a floating point number results in Infinity not an exception.
            // I've removed dividing by zero as a possibility in this implementation by handling that in the constructor.
            return distance / _movementSpeed;
        }
    }
}
