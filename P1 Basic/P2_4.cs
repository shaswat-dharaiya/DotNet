using System;

public class P2_4 
{
	public P2_4()
	{
	}

    public static void Main()
    {
        Maruti m1 = new Maruti("maruti",1,"top");
        Car c = new Car();
        m1.display();
    }
}

public class Car
{
   public Car() { }
    protected int id;
    protected string name;
    private string model;

    public Car(string model)
    {
        this.model = model;
    }
    public void display()
    {
        Console.WriteLine(name);
        Console.WriteLine(id);
        Console.WriteLine(model);
    }
}

public class Maruti : Car
{
    public Maruti() {
        //id = 1;
        //name = "maruti";
    }
    public Maruti(String name, int id, string model) : base(model)
    {
        this.name = name;
        this.id = id;
        
    }
}

public class Mahindra : Car
{
    public Mahindra() {

    }
}