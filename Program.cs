using System;
using System.Linq;
using System.Collections.Generic;


public interface ISwimming
{
    double WaterSpeed { get; set; }
    string Mechanism { get; set; }
    void Swim();
}

public interface IFlying
{
    double AirSpeed { get; set; }
    string Mechanism { get; set; }
    void Fly();
}

public interface IWalking
{
    double GroundSpeed { get; set; }
    int Legs { get; set; }
    void Walk();
}

public class FlyingSquirrel : IWalking, IFlying
{
    public double GroundSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Legs { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public double AirSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Mechanism { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Fly()
    {
        Console.WriteLine("The squirrel opens it arms and glies through the air on skin flaps");
    }

    public void Walk()
    {
        // throw new NotImplementedException();
        Console.WriteLine("test walking eagle");
    }
}

public class Eagle : IFlying, IWalking
{
  public double AirSpeed { get; set; }
  public string Mechanism { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  public double GroundSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  public int Legs { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

  public void Fly()
  {
    Console.WriteLine("The eagle magestically spreads its wings and soars miles in the air");
  }

  public void Walk()
  {
    // throw new NotImplementedException();
    Console.WriteLine("test walking eagle");
  }
}

public class Program
{

    public static void Main() {
        FlyingSquirrel rocky = new FlyingSquirrel();
        Eagle sam = new Eagle();

        List<IWalking> birds = new List<IWalking>();
        //type squirrel , class squirrel
        birds.Add(sam);
        //type eagle, class eagle
        birds.Add(rocky);

        // the foreach will loop through rocky-type FlyingSquirrel , sam-type Eagle
        foreach (var thing in birds)
        {
            //each thing has a type or class, will refer to the method fly in that specific class
            // fly method consoles a message
            // thing.Fly();
            thing.Walk();

        }
        sam.Fly();
        sam.Walk();
        sam.AirSpeed = 5;
        Console.WriteLine($"sam's airspeed {sam.AirSpeed}");
        
    }

}








