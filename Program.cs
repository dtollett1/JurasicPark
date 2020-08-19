using System;
using System.Collections.Generic;


namespace JurasicPark
{
    class Program
    {
        class Dinosaur
        {
            public string Name { get; set; }
            public string DietType { get; set; }
            public DateTime whenAcquired { get; set; } = DateTime.Now;
            public int Weight { get; set; }
            public int Enclosure { get; set; }

        }
        static void Main(string[] args)
        {

            var dinosaurs = new List<Dinosaur>();

            //       P - Problem

            // Create a console application that manages a zoo full of dinosaurs.

            // Create an application that allows us to:

            // CRUD
            // - Create: Add (create) a new Dinosaur that is available for adoption
            // - Read: Get lists of Dinosaurs that are housed at the park - ordered by date acquired and by enclosure number
            // - Update: Update information about a dinosaur that is at the park
            // - Delete: Remove a dinosaur from the park

            // E - Examples:

            // - Name type of dinosaur - string
            // - Diet Type (herbivore/Carnivore) - string
            // - When Acquired  This will default to the current time when the dinosaur is created - int
            // - Weight  How heavy the dinosaur is in pounds- string
            // - Enclosure Number  the number of the pen the dinosaur is in - string



            // D - Data

            // Dinosaur class

            // list of Dinosaurs



            // A - Algorithm

            // Welcome the user to the application

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("||----WELCOME TO JURASSIC PARK----||");
            Console.WriteLine();
            Console.WriteLine();



            // While the user hasn't quit the application
            var hasQuitTheApplication = false;
            while (hasQuitTheApplication is false)
            {


                // Show them a menu of options they can do

                // View - This command will show the all the dinosaurs in the list, ordered by WhenAcquired

                // Add - This command will let the user type in the information for a dinosaur and add it to the list.

                // Remove -  This command will prompt the user for a dinosaur name then find and delete the dinosaur with that name. 

                // Transfer - This command will prompt the user for a dinosaur name and a new EnclosureNumber and update that dino's information.

                // Summary - This command will display the number of carnivores and the number of herbivores.

                // Quit - This will stop the program
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("VIEW - View Dinosaurs in the park");
                Console.WriteLine("ADD - Add a new dinosaur");
                Console.WriteLine("REMOVE - Remove a dionsaur from the park");
                Console.WriteLine("TRANSFER - Transfer dinosaur to a new enclosure");
                Console.WriteLine("SUMMARY - Display number of herbivores and carnivores");
                Console.WriteLine("QUIT - This will exit the program");
                Console.WriteLine();
                Console.WriteLine("CHOICE:");
                var choice = Console.ReadLine().ToUpper();

                if (choice == "QUIT")
                {
                    hasQuitTheApplication = true;
                }

                if (choice == "VIEW")
                {
                    // Show a list of all the dinosaurs.




                }

                if (choice == "ADD")
                {
                    // Show a list of all the dinosaurs.

                }

                if (choice == "REMOVE")
                {
                    // Show a list of all the dinosaurs.

                }
                if (choice == "TRANSFER")
                {
                    // Show a list of all the dinosaurs.

                }
                if (choice == "SUMMARY")
                {
                    // Show a list of all the dinosaurs.

                }



                Console.WriteLine("---GOODBYE---");



            }
        }
    }
}
