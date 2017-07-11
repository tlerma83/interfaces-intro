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
        Console.WriteLine("It opens it arms and glies through the air on skin flaps");
    }

    public void Walk()
    {
        throw new NotImplementedException();
    }
}

public class Eagle : IFlying, IWalking
{
  public double AirSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  public string Mechanism { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  public double GroundSpeed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  public int Legs { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

  public void Fly()
  {
    Console.WriteLine("The eagle magestically spreads its wings and soars miles in the air");
  }

  public void Walk()
  {
    throw new NotImplementedException();
  }
}

public class Program
{

    public static void Main() {
        FlyingSquirrel rocky = new FlyingSquirrel();
        Eagle sam = new Eagle();

        List<IFlying> birds = new List<IFlying>();
        birds.Add(sam);
        birds.Add(rocky);

        foreach (var thing in birds)
        {
            thing.Fly();
        }
        
    }

}








