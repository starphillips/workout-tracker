Console.WriteLine("What type of session today? \n");

foreach (var name in Enum.GetNames<WorkoutType>())
{
    Console.WriteLine($"- {name}");

}
Console.WriteLine();

WorkoutType selectedType;

while(true)
{
    string? usersWorkoutType = (Console.ReadLine() ?? "").ToLower();

    if (Enum.TryParse(usersWorkoutType, true, out selectedType))
    {
        break;
    }
    if (string.Equals(usersWorkoutType, "help"))
    {
        Console.WriteLine("Strength = Higher weight, low reps");
        Console.WriteLine("Hypertrophy = Lower weight, high reps");
        Console.WriteLine();
        continue;
    }
    else
    {
        Console.WriteLine("Please choose from either 'Strength' OR 'Hypertrophy'.");
        Console.WriteLine("Type 'help' for an explanation of each.");
        Console.WriteLine();
    }
}

Console.WriteLine("What muscle group did you train today? \n");
Console.WriteLine("Please select ONE from the list below: \n");

foreach (var name in Enum.GetNames<MuscleGroup>())
{
    Console.WriteLine($"- {name}");

}
Console.WriteLine();

MuscleGroup selectedGroup;

while (true)
{
    string? usersMuscleGroup = Console.ReadLine();
    Console.WriteLine();

    if (Enum.TryParse(usersMuscleGroup, true, out selectedGroup))
    {
        break;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Sorry this muscle group does not currently exist in our tracker application or you have selected too many.");
        Console.WriteLine();
    }
}                                                                                                                  


List<Exercise> activeExercises = ExerciseLibrary.GetActiveByMuscleGroup(selectedGroup);

var session = new WorkoutSession();

session.MuscleGroup = selectedGroup;
session.WorkoutType = selectedType;

Console.WriteLine("For each exercise write your sets as follows: reps x weight.");
Console.WriteLine("Followed by , to separate each.\n");
Console.WriteLine("Example: If you did 3 sets: 12 reps of 50, 10 reps of 50.5 and 10 reps of 50.5");
Console.WriteLine("You will write 12x50, 10x50.5, 10x50.5 \n");

foreach (Exercise exercise in activeExercises)
{
    Console.WriteLine(exercise.Name); 

    while (true)
    {
        string? usersSets = Console.ReadLine();
        Console.WriteLine();

        if (Set.TryParseSets(usersSets ?? "", out List<Set> sets, out string error)) {
            // ExerciseLog log = new ExerciseLog();
            // log.Exercise = exercise;
            // log.Sets = sets;
            // session.ExerciseLogs.Add(log);
            session.ExerciseLogs.Add(new ExerciseLog { Exercise = exercise, Sets = sets });
            break;
        }
        else
        {
            Console.WriteLine(error);
        }
    }
}

Console.WriteLine($"{session.Date} - {session.MuscleGroup} ({session.WorkoutType})");

foreach (ExerciseLog log in session.ExerciseLogs)
{
    Console.WriteLine($"{log.Exercise.Name} [{log.Exercise.ExerciseType}]");

    foreach (Set set in log.Sets)
    {
        Console.WriteLine($"{set.Reps} reps @ {set.Weight}kg");
    }
    Console.WriteLine();
}