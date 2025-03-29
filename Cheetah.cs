public class Cheetah : ICatBehavior{ //Didn't set as animal for a purpose

    string Name;
    public Cheetah(string Name) {
        this.Name = Name;
    }
    public void climbWall(){
        Console.WriteLine($"{this.Name} (cheetah) climbed a wall");
    }
}