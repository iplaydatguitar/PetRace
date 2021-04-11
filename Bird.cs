using System.Configuration;

namespace PetRace
{
    class Bird : IPet
    {
        public float GetDefaultSpeed()
        {
            //this could throw an exception if the parse fails or the setting cannot be found
            return float.Parse(ConfigurationManager.AppSettings["birdSpeed"]);
        }
    }
}
