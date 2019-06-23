namespace animals.Models
{
    public class Horse : Animal
    {
        private const string SOUND = "MIHAHA";
        public Horse(string name) : base(name)
        {
        }

        public override string MakeSound()
        {
            return SOUND;
        }
    }
}