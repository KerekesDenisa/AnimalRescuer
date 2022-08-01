using AnimalRescuer;

class App
{
    public static void Main(string[] args)
    {
        Animal animal = new Animal("Toto", 2, 8,5,"Happy Dogs", "Play with cats");
        Adoption adoption = new Adoption("Deni", 1200);
        AnimalFood animalFood = new AnimalFood("Happy Dogs", 45, 2, new DateOnly(2023,02,05), true);
        RecreationalActivity recreationalActivity = new RecreationalActivity("Play with cats");
        Vetrinarian vetrinarian = new Vetrinarian("Pop Elena", "dog");
        Play play = new Play(adoption, animal, vetrinarian);

    }
}