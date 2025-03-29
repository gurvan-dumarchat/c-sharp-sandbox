class Program{
    public static void Main(){
        Animal a1 = new Cat("Gato");
        Animal a2 = new Dog("Doggo");
        a1.sayName();
        a2.sayName();
        a1.doSound();
        a2.doSound();
        Cat cat = (Cat) a1;
        List<ICatBehavior> felines = new List<ICatBehavior>();
        Cheetah c1 = new Cheetah("Faaaast");
        felines.Add(cat);
        felines.Add(c1);
        foreach (var feline in felines)
        {
            feline.climbWall();
        }
    }
}