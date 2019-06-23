namespace animals.Models
{
    public class Dog : Animal
    {
        private const string SOUND = "BARK";

        public Dog(string name) : base(name)
        {
        }

        public override string MakeSound()
        {
            return SOUND;
        }
    }
}