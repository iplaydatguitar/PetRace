using System;
using System.Numerics;

namespace PetRace
{
    /*
     * My refactor idea was to change BasicPet to an abstract class and exchange the Type property and the PetType enum for pet specific inherited subclasses.
     * I also made the default speeds of each pet a const variable in each class (more comments on this in the pet specific classes). 
     * This removed the long switch and if/else statements in the original implementation. I recognize that my tiny pet subclasses are little more than a different way
     * to represent PetType and store the default speed value. However I think there's more benefit here in future expandability and maintainability. 
     * Additionally, I believe it makes the caller code more readable because it will be more explicit which type of pet they'd like to create/use due to it being 
     * represented in the class name itself.
     * 
     * This could've been done without the pet specific classes via a default speed lookup function and const pet speed default variables. However that still results
     * in an ever expanding class that doesn't lend itself to easy expandability or maintainability.
     */
    abstract class BasicPet
    {
        private readonly float _movementSpeed = 1f; // speed is now a readonly member variable so it can be customized at object creation if desired.
        private Vector2 _start; // the start value is only ever used or set within this class. Just make it a private member variable.

        // subclasses now provide their own specific speed. It is set and checked for validity in the base blass.
        public BasicPet(Vector2 start, float speed)
        {
            _start = start; // no need to check for null since Vector2 is a struct

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
