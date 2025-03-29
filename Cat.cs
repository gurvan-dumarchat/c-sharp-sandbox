public class Cat : Animal,ICatBehavior{
    public Cat(string Name) : base(Name) {}
    public override void doSound(){
        Console.WriteLine("Miaou");
    }

    public void climbWall(){
        Console.WriteLine($"{this.Name} climbed a wall");
    }
}