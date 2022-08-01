using AnimalRescuer;

class App
{
    public static void Main(string[] args)
    {
        Animal animal = new Animal("Toto", 2, 8, 5, 2,"Happy Dogs", "Play with cats");
        Adoption adoption = new Adoption("Deni", 1200);
        AnimalFood animalFood = new AnimalFood("Happy Dogs", 45, 2, new DateOnly(2023,02,05), true);
        RecreationalActivity recreationalActivity = new RecreationalActivity("Play with cats");
        Vetrinarian vetrinarian = new Vetrinarian("Pop Elena", "dog");
        Play play = new Play(adoption, animal, vetrinarian);
  

        Console.WriteLine(animal.Name);
        animal.Name = "jiji";
        Console.WriteLine(animal.Name);
        Console.WriteLine(animal.toString());
        Console.WriteLine(vetrinarian.toString());

        Rabbit myRabbit = new Rabbit("Puficu", 3, 10, 8, 10, "Puficios", "Sleep", false);
        Console.WriteLine(myRabbit.toString());
        myRabbit.jump();




    }
}