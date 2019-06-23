using animals.Services;

namespace animals
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalService animalService = new AnimalService();

            animalService.ShowAnimals();
        }
    }
}
