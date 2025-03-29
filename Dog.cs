public class Dog : Animal{
    public Dog(string Name) : base(Name) {}
    public override void doSound(){
        Console.WriteLine("Woof !");
    }
}