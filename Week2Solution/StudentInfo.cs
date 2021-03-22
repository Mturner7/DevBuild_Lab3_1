using System;

namespace StudentInfo
{
    class StudentInfo
    {
        private static string[] students = 
        { 
            "Annie May", "Ben Dover",
            "Mike Rack", "John Doe", 
            "Steven Sinclair", "Balrog the Destroyer", 
            "Tyrone Wilkinson", "Kyle Bal", 
            "William Arthur Prescott", "Dale Jarvis"
        };

        private static string[] previousTitles = 
        { 
            "Math Teacher", "The Benster", 
            "Professional Dog hair-braider", "Cashier", 
            "Deceased", "Ruler of Middle Earth", 
            "Radio Host", "Veteran", 
            "Detective", "Influencer" 
        };
        
        private static string[] favoriteFoods = 
        { 
            "Mochi", "Cold butter", 
            "Shrimp", "Ice cubes", 
            "Raw eggs", "The blood of his enemies", 
            "Watermelon", "Sodium", 
            "Lukewarm soup", "Ice cream"
        };

        private static void viewAllStudents()
        {
            int i = 1;

            Console.WriteLine();
            foreach (string student in students)
            {
                Console.WriteLine($"{i}. {student}");
                i++;
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            int index;
            string student;
            string title;
            string food;
            string input;
            bool done = false;

            while (!done)
            {
                Console.Write("Which student do you want to learn about? (enter a number 1-9 or '10' to view all students): ");
                input = Console.ReadLine();
                Int32.TryParse(input, out index);
                
                while (index < 1 || index > 10)
                {
                    Console.Write("Please enter a valid integer between 1 and 9 or '10' to view all the students: ");
                    input = Console.ReadLine();
                    Int32.TryParse(input, out index);
                }

                if (index == 10)
                {
                    viewAllStudents();
                    continue;
                }

                student = students[index - 1];
                title = previousTitles[index - 1];
                food = favoriteFoods[index - 1];

                Console.WriteLine($"\nStudent {index} is {student}.\n");

                Console.Write("What would you like to learn about this student? (favorite food / previous title ): ");
                input = Console.ReadLine().ToLower();

                while (!input.Contains("food") && !input.Contains("title"))
                {
                    Console.Write("That category is non-existent, please enter a  valid category! (favorite food/previous title): ");
                    input = Console.ReadLine();
                }

                if (input.Contains("food")) Console.WriteLine($"\n{student}s favorite food is '{food}'\n");
                else if (input.Contains("title")) Console.WriteLine($"\n{student}s previous title was '{title}'\n");

                do
                {
                    Console.Write("Would you like to continue? (enter 'y' or 'n'): ");
                    input = Console.ReadLine();

                } while (input != "y" && input != "n");

                if (input == "n") done = true;

            } 

            Console.WriteLine("Thank you!");
        }
    }
}
