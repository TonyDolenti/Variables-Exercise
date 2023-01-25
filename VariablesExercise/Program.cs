namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string favChestExercise = "bench press";
            int chestExerciseWeight = 185;
            char lastInitial = 'D';
            bool isOver18 = true;
            double age = 20;
            decimal bodyFatPercentage = 19.05m;

            Console.WriteLine($"Favorite chest exercise: {favChestExercise}");
            Console.WriteLine($"With how much weight: {chestExerciseWeight}");
            Console.WriteLine($"Initial of last name: {lastInitial}");
            Console.WriteLine($"Is over 18: {isOver18}");
            Console.WriteLine($"Specific age: {age}");
            Console.WriteLine($"Body fat percentage: {bodyFatPercentage}");
        }
    }
}
