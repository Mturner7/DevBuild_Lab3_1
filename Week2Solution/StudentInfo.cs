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
            "Watermelon", "Anything ball shaped", 
            "Lukewarm soup", "Ice cream"
        };

        private static void viewAllStudents()
        {
            int i = 1;
            foreach (string student in students)
            {
                Console.WriteLine($"{i}. {student}");
                i++;
            }
        }

        public static void Main(string[] args)
        {
            
        }
    }
}
