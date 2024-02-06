namespace dz5_task1
{
class HealthMonitor
    {
        private int totalPhysicalActivityMinutes = 0;
        private int totalCaloriesConsumed = 0;
        private bool hasHealthyHabit = false;

        public void LogPhysicalActivity()
        {
            Console.WriteLine("Enter the duration of physical activity in minutes:");
            int activityMinutes = GetChoice();

            totalPhysicalActivityMinutes += activityMinutes;

            Console.WriteLine($"Logged {activityMinutes} minutes of physical activity.");
        }

        public void LogFoodIntake()
        {
            Console.WriteLine("Enter the number of calories consumed:");
            int caloriesConsumed = GetChoice();

            totalCaloriesConsumed += caloriesConsumed;

            Console.WriteLine($"Logged {caloriesConsumed} calories consumed.");
        }

        public void SetHealthyHabit()
        {
            Console.WriteLine("Do you have a healthy habit? (true/false):");
            bool input = GetBooleanChoice();

            hasHealthyHabit = input;

            Console.WriteLine("Healthy habit set.");
        }

        public void ViewHealthSummary()
        {
            Console.WriteLine("Health Summary:");
            Console.WriteLine($"Total Physical Activity: {totalPhysicalActivityMinutes} minutes");
            Console.WriteLine($"Total Calories Consumed: {totalCaloriesConsumed} calories");
            Console.WriteLine($"Healthy Habit: {(hasHealthyHabit ? "Yes" : "No")}");

            if (totalPhysicalActivityMinutes < 30)
            {
                Console.WriteLine("Recommendation: Increase physical activity to at least 30 minutes a day.");
            }

            if (totalCaloriesConsumed > 2500)
            {
                Console.WriteLine("Recommendation: Consider a balanced diet with fewer calories.");
            }

            if (!hasHealthyHabit)
            {
                Console.WriteLine("Recommendation: Establish a healthy habit for overall well-being.");
            }
        }

        private static int GetChoice()
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
            return choice;
        }

        private static bool GetBooleanChoice()
        {
            bool choice;
            while (!bool.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter true or false.");
            }
            return choice;
        }
    }
    class Program
    {
        static void Main()
        {
            HealthMonitor healthMonitor = new HealthMonitor();

            while (true)
            {
                Console.WriteLine("1. Log physical activity");
                Console.WriteLine("2. Log food intake");
                Console.WriteLine("3. Set healthy habit");
                Console.WriteLine("4. View health summary");
                Console.WriteLine("5. Exit");

                int choice = GetChoice();

                switch (choice)
                {
                    case 1:
                        healthMonitor.LogPhysicalActivity();
                        break;
                    case 2:
                        healthMonitor.LogFoodIntake();
                        break;
                    case 3:
                        healthMonitor.SetHealthyHabit();
                        break;
                    case 4:
                        healthMonitor.ViewHealthSummary();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }

        static int GetChoice()
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
            return choice;
        }
    }

    
}
