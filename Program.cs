using System;
using static ExampClass;

class Program
{
    public static void Main(string[] args)
    {
        //Animal animal = new Animal(15, "Herbivore");
        //animal.Kind = "Mammal";
        //animal.GetOld();
        //Console.WriteLine(animal.Kind);

        //Dog dog = new Dog(15);
        //dog.DogInfo();

        //Student student = new Student();
        //student.GetSetName = "Matias";
        //student.GetSetGrade = 33;

        ExampClass item = new ExampClass("matias", 12);
        Console.WriteLine(item.ToString());
        Writer writer = new Writer();
        item.WriteYourself(writer);

        ExampClass.InnerClass Inner_Item = new ExampClass.InnerClass();
        Inner_Item.OutClassInfo(item);
    }
}

class Calculator
{
    private int a; //atribute of the class
    private int b;

    public Calculator(int a, int b) //Constructor
    {
        this.a = a; //determine property
        this.b = b;
    }
    public int Sum()
    {
        return this.a + this.b;
    }
    public int Subtract()
    {
        return this.a - this.b;
    }
    public int Multiple()
    {
        return this.a * this.b;
    }
    public int Divide()
    {
        return this.a / this.b;
    }
}

class Car
{
    public string Brand;
    public int Year;

    public Car()
    {
        Console.WriteLine("There is a car");
    }
    public Car(string brand)
    {
        Brand = brand;
    }
    public Car(string brand, int year)
    {
        Year = year;
        Brand = brand;
    }
}

public class Animal
{
    public string Kind;
    private int Age;
    protected string nutritionType;

    public Animal(int age,string nutType)
    {
        this.Age = age;
        this.nutritionType = nutType;
    }

    public void GetOld()
    {
        this.Age++;
    }
    private void Sleep()
    {
        Console.WriteLine("Sleeping..");
    }
    protected void Eating() {
        Console.WriteLine("Eating...");
            }
}
public class Dog : Animal
{
    public Dog(int age): base(age, "Carnivore") { }
    public void DogInfo()
    {
        //Console.WriteLine($"How old is the dog? {this.Age}");
        Eating();
        //Sleep();
    }
}

class Student
{
    private string name;
    private int grade;

    public string GetSetName
    {
        get { return name; }
        set { name = value; }
    }

    public int GetSetGrade
    {
        get { return grade; }
        set { if (value > 0 && value <= 100) grade = value; }
    }
    public void Print()
    {
        Console.WriteLine(name, grade);
    }

}

public class ExampClass
{
    private string name;
    private int age;

    public ExampClass(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public class InnerClass
    {
        public void OutClassInfo(ExampClass Outer_Object)
        {
            Console.WriteLine($"outer object name: {Outer_Object.name} age : {Outer_Object.age}"); 
        }
    }
    public void WriteYourself(Writer writer)
    {
        writer.Print(this);
    }

    public override string ToString()
    {
        return age + " " + name;
    }

    
}
public class Writer
    {
        public void Print(ExampClass item)
        {
            Console.WriteLine(item);
        }
    }