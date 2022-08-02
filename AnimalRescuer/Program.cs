using AnimalRescuer;

class App
{
    public static void Main(string[] args)
    {
        Father father = new Father("Gigi", 45, "blonde", "tall");


        Dog dog = new Dog
            {
                Age = 1,
                Weight = 1,
                isHungry = true,
                HappinesLevel = HappinessStates.SAD,
                Name = "",
                Breed = "Corcitura de labrador",
                Scared = true
            };

        Cat cat = new Cat
        {
            Age = 1,
            Weight = 1,
            isHungry = true,
            HappinesLevel = HappinessStates.NEUTRAL,
            Name = "KIKI",
        };


        Duck duck = new Duck
        {
            Age = 1,
            Weight = 1,
            isHungry = false,
            HappinesLevel = HappinessStates.HAPPY,
            Name = "FIFI"
        };


        Girl girl = new Girl("Ana", 7, "roscat", "small", true, dog);


       
        AnimalShelter shelter = new AnimalShelter();
        shelter.addAnimal(dog);
        shelter.addAnimal(cat);
        shelter.addAnimal(duck);

        girl.Adopt(dog);
        shelter.removeAnimal(dog);

        girl.nameAnimal("Toto");

        DogFood dogFood = new DogFood();
        girl.feedAnimal(dogFood);
        dog.HappinesLevel = HappinessStates.HAPPY;

    }
}