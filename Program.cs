using System;

namespace Bulldozer
{
  class Program
  {
    static void Main(string[] args)
    {
      // instantiate Car class
      var car1 = new Car("Red", "Toyota");

      Console.WriteLine(car1);

      var saloonCar1 = new SaloonCar(2);
      var saloonCar2 = new SaloonCar(3, "Nissan");
      var saloonCar3 = new SaloonCar(4, "Ford", "Purple");

      Console.WriteLine(saloonCar1);
      Console.WriteLine(saloonCar2);
      Console.WriteLine(saloonCar3);
    }
  }

  // Assignment
  // TODO Make a Car class; color and manu
  // TODO Instancaite this class w/ red and toyota
  // TODO Make new SaloonCar class that inherits from Car class; new prop in SaloonCar: numberOfSeats
  // TODO 3 constructors
    // assign numberOfSeats only
    // assign numberOfSeats and manu only
    // assign numberOfSeats, manu, and color
  // TODO Create 3 Objects
    // saloonCar1 w/ 2 seats
    // saloonCar2 w/ 3 seats and manu Nissan
    // saloonCar3 w/ 4 seats, manu Ford, and color purple

  // Car Class
  public class Car
  {
    public Car(string _color, string _manu) {
      this.color = _color;
      this.manu = _manu;
    }
    
    // props for color and manu
    public string color {get; set;}
    public string manu {get; set;}

    // will override value to become strings
    // c# is calling .ToString() on each value in the return
    public override string ToString() {
      return $"{manu}, {color}";
    }
  }

  // SaloonCar class
  public class SaloonCar : Car
  { 
    // prop for numberOfSeats
    public int numberOfSeats {get; set;}

    // number of seats, manu, and color
    public SaloonCar(int _numberOfSeats, string _manu, string _color) : base(_color, _manu) {
      this.numberOfSeats = _numberOfSeats;
    }

    // number of seats and manu only
    public SaloonCar(int _numberOfSeats, string _manu) : base("no color", _manu) {
      this.numberOfSeats = _numberOfSeats;
    }

    // number of seats only
    public SaloonCar(int _numberOfSeats) : base("no color", "no manu") {
      this.numberOfSeats = _numberOfSeats;
    }

    // will override value to become strings
    // c# is calling .ToString() on each value in the return
    public override string ToString() {
      return $"{numberOfSeats}, {manu}, {color}";
    }
  }













  // Encapsulation
  // aka Data Hiding
  // Putting data handling and creation within classes to simplify the code
  // public class FactoryWorker
  // {
  //   public FactoryWorker() {

  //   }

  //   public int AddNumbers(int num1, int num2) {
  //     var result = num1 + num2;
  //     return result;
  //   }
  // }

  // Polymorphism
  // public class FactoryWorker
  // {
  //   // constructor
  //   public FactoryWorker () {

  //   }

  //   // class method
  //   public void Count (int number) {
  //     if (Total == null)
  //       Total = 0;

  //     Total = Total + Convert.ToSingle(number);
  //     Console.WriteLine(Total.ToString());
  //   }

  //   // can use the same function name only when the argument is of a different type
  //   // only called when Count is passed a float
  //   public void Count (float number) {
  //     Total = Total + number;
  //     Console.WriteLine(Total.ToString());
  //   }

  //   // class variable
  //   public float Total { get; set; }
  // }

  // Inheritance
  // // inheritance object
  // public class GeneralObject
  // {
  //   public GeneralObject () {

  //   }

  //   public bool moves { get; set; }
  //   public string color { get; set; }
  // }

  //   // will inherit the props from GeneralObject
  //   public class Human : GeneralObject
  //   {
  //     public Human () {

  //     }

  //     public string name { get; set; }
  //   }

  //     // create a class
  //     // will inherit the props from Human which got props from GeneralObject
  //     public class Man : Human
  //     {
  //       // contructor
  //       public Man () {
  //       }
  //     }

  //     public class Woman : Human
  //     {
  //       public Woman () {

  //       }
  //     }

  // public class Kart : GeneralObject
  // {
  //   public Kart () {

  //   }

  //   public string manufacturer { get; set; }
  // }

  // public class Alien : GeneralObject
  // {
  //   public Alien () {

  //   }

  //   public string planet { get; set; }
  // }
}
