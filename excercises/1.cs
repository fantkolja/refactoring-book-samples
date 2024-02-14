static void AnimalActions(Zoo zoo)
{
  Console.OutputEncoding = Encoding.UTF8;
  int newAnimalAge;

  while (true)
  {
    Console.Clear();
    Console.WriteLine("Action with animals:");
    Console.WriteLine("1 - View all animals");
    Console.WriteLine("2 - Change animal data");
    Console.WriteLine("3 - Delete animal");
    Console.WriteLine("4 - Add an animal");
    Console.WriteLine("5 - Return to main menu");

    string choice = Console.ReadLine();

    switch (choice)
    {
      case "1":
        Console.WriteLine("List of all animals:");
        foreach (var animal in zoo.Animals)
        {
          Console.WriteLine($"Species: {animal.Species}, Subspecies: {animal.Subspecies}, Age: {animal.Age}");
        }
        break;
      case "2":
        Console.WriteLine("Enter the type of animal to change data:");
        string speciesToEdit = Console.ReadLine();
        Console.WriteLine("Enter the animal subspecies to change data:");
        string subspeciesToEdit = Console.ReadLine();
        Animal animalToEdit = zoo.Animals.Find(
          a => a.Species == speciesToEdit && a.Subspecies == subspeciesToEdit
        );
        if (animalToEdit != null)
        {
          Console.WriteLine($"Enter new age for animal {speciesToEdit} {subspeciesToEdit}:");
          if (int.TryParse(Console.ReadLine(), out newAnimalAge))
          {
            animalToEdit.Age = newAnimalAge;
            Console.WriteLine("Data changed successfully.");
          }
          else
          {
            Console.WriteLine("Invalid age format. Please enter an integer.");
          }
        }
        else
        {
          Console.WriteLine("No animal found.");
        }
        break;
      case "3":
        Console.WriteLine("Enter the type of animal to delete:");
        string speciesToDelete = Console.ReadLine();
        Console.WriteLine("Enter the animal subspecies to delete:");
        string subspeciesToDelete = Console.ReadLine();
        Animal animalToDelete = zoo.Animals.Find(
          a => a.Species == speciesToDelete && a.Subspecies == subspeciesToDelete
        );
        if (animalToDelete != null)
        {
          zoo.Animals.Remove(animalToDelete);
          Console.WriteLine($"Animal {speciesToDelete} {subspeciesToDelete} has been removed from the zoo.");
        }
        else
        {
          Console.WriteLine("No animal found.");
        }
        break;
      case "4":
        Console.WriteLine("Enter the appearance of the new animal:");
        string newSpecies = Console.ReadLine();
        Console.WriteLine("Enter the subspecies of the new animal:");
        string newSubspecies = Console.ReadLine();
        Console.WriteLine("Enter the age of the new animal:");
        int newAge = int.Parse(Console.ReadLine());
        zoo.Animals.Add(
          new Animal { Species = newSpecies, Subspecies = newSubspecies, Age = newAge }
        );
        Console.WriteLine($"Animal {newSpecies} {newSubspecies} has been added to the zoo.");
        break;
      case "5":
        return;
      default:
        Console.WriteLine("Invalid selection. Please try again.");
        break;
    }
    Console.WriteLine("Press Enter to continue...");
    Console.ReadLine();
  }
}