using System;
using System.Collections.Generic;

public class Pet
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Pet()
    {

    }

    public Pet(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}

public interface IDog
{
    void Bark();
    void Fetch();
}

public class Dog : Pet, IDog
{
    private string license;

    public Dog(string license, string name, int age) : base(name, age)
    {
        this.license = license;
    }

    public void Bark()
    {
        Console.WriteLine("{0} is barking.", Name);
    }

    public void Fetch()
    {
        Console.WriteLine("{0} is fetching.", Name);
    }
}

public interface ICat
{
    void Meow();
    void Scratch();
}

public class Cat : Pet, ICat
{
    public Cat()
    {

    }

    public void Meow()
    {
        Console.WriteLine("{0} is meowing.", Name);
    }

    public void Scratch()
    {
        Console.WriteLine("{0} is scratching.", Name);
    }
}

public class Pets
{
    private List<Pet> petList = new List<Pet>();

    public Pet this[int nPetEl]
    {
        get
        {
            Pet returnVal;
            try
            {
                returnVal = (Pet)petList[nPetEl];
            }
            catch
            {
                returnVal = null;
            }

            return (returnVal);
        }

        set
        {
            // if the index is less than the number of list elements
            if (nPetEl < petList.Count)
            {
                // update the existing value at that index
                petList[nPetEl] = value;
            }
            else
            {
                // add the value to the list
                petList.Add(value);
            }
        }
    }

    public int Count
    {
        get { return petList.Count; }
    }

    public void Add(Pet pet)
    {
        petList.Add(pet);
    }

    public void Remove(Pet pet)
    {
        petList.Remove(pet);
    }

    public void RemoveAt(int petEl)
    {
        petList.RemoveAt(petEl);
    }
}

public class Program
{
    public static void Main()
    {
        Pet thisPet = null;
        Dog dog = null;
        Cat cat = null;
        IDog iDog = null;
        ICat iCat = null;
        Pets pets = new Pets();
        Random rand = new Random();

        for (int i = 0; i < 50; i++)
        {
            // 1 in 10 chance of adding an animal
            if (rand.Next(1, 11) == 1)
            {
                if (rand.Next(0, 2) == 0)
                {
                    // add a dog
                    Console.WriteLine("Enter dog's license number:");
                    string license = Console.ReadLine();
                    Console.WriteLine("Enter dog's name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter dog's age:");
                    int age = int.Parse(Console.ReadLine());
                    dog = new Dog(license, name, age);
                    pets.Add(dog);
                }
                else
                {
                    // else add a cat
                    Console.WriteLine("Enter cat's name:");
                }
            }
        }
    }
}
