public abstract class Animal{
    protected string Name {get;set;}
    public Animal(string Name){
        this.Name = Name;
    }

    public void sayName (){
        Console.WriteLine(this.Name);
    }
    public abstract void doSound();
}