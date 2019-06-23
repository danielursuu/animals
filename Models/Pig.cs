namespace animals.Models
{
    public class Pig : Animal, IMakeSound
    {
        private const string SOUND = "GROH";

        public Pig(string name) : base(name)
        {
        }

        public override string MakeSound()
        {
            return SOUND;
        }
    }
}