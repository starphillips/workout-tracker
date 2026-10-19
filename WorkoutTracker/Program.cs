// Hardcodede Input - exercises and sets

// Exercise hipThrusts = new Exercise{Name = "Hip Thrusts", MuscleGroup = MuscleGroup.Glutes, ExerciseType = ExerciseType.Compound};
// Exercise singleLegRDL = new Exercise { Name = "Single Leg RDL", MuscleGroup = MuscleGroup.Glutes, ExerciseType = ExerciseType.Compound};
// Exercise bulgarianSplitSquats = new Exercise {Name = "Bulgarian Split Squats", MuscleGroup = MuscleGroup.Glutes, ExerciseType = ExerciseType.Compound};
// Exercise cableKickbacks = new Exercise {Name = "Cable Kickbacks", MuscleGroup = MuscleGroup.Glutes, ExerciseType = ExerciseType.Isolation};

// WorkoutSession session = new WorkoutSession {
//     MuscleGroup = MuscleGroup.Glutes,
//     WorkoutType = WorkoutType.Strength,
//     ExerciseLogs = new List<ExerciseLog>
//     {        
//         new ExerciseLog {Exercise = hipThrusts, Sets = {new Set { Reps = 12, Weight = 42.5}, new Set {Reps = 12, Weight = 45}}},
//         new ExerciseLog {Exercise = singleLegRDL, Sets = {new Set {Reps = 12, Weight = 32}, new Set {Reps = 12, Weight = 32}, new Set {Reps = 10, Weight = 32}}},
//         new ExerciseLog {Exercise = bulgarianSplitSquats, Sets = {new Set {Reps = 8, Weight = 16}, new Set {Reps = 8, Weight = 16}, new Set {Reps = 8, Weight = 16}}},
//         new ExerciseLog {Exercise = cableKickbacks, Sets = {new Set {Reps = 12, Weight = 14}, new Set {Reps = 14, Weight = 14}, new Set {Reps = 12, Weight = 16}}}
//     }
// };


// Hardcoded Test

// Establish a new workout session which includes an exercise log for each completed exercise

// Foreach loop adds in the records we've hardcoded in for our session

// Console.WriteLine($"{session.Date} - {session.MuscleGroup} ({session.WorkoutType})");

// foreach (ExerciseLog log in session.ExerciseLogs)
// {
//     Console.WriteLine($"{log.Exercise.Name} [{log.Exercise.ExerciseType}]");

//     foreach (Set set in log.Sets)
//     {
//         Console.WriteLine($"{set.Reps} reps @ {set.Weight}kg");
//     }
// }



// User Input

Console.WriteLine("What muscle group did you train today? \n");

Console.WriteLine("Please select ONE from the list below: \n");

foreach (var name in Enum.GetNames<MuscleGroup>())
{
    Console.WriteLine($"- {name}");
}

MuscleGroup selectedGroup;

while (true)
{
    string? usersMuscleGroup = Console.ReadLine();

    if (Enum.TryParse(usersMuscleGroup, true, out selectedGroup))
    {
        break;
    }
    else
    {
        Console.WriteLine("Sorry this muscle group does not currently exist in our tracker application or you have selected too many.");
    }

}

List<Exercise> activeExercises = ExerciseLibrary.GetActiveByMuscleGroup(selectedGroup);

foreach (Exercise exercise in activeExercises)
{
    Console.WriteLine(exercise.Name);
    
}





/*
--- User Input Implementation: ---

.Add() is better when the data isn't know in advance i.e. when the user is inputting their workout data.

--- Example of what our logic will be doing under the hood when it comes to user input: ---

var session = new WorkoutSession();
session.MuscleGroup = MuscleGroup.Back;
session.WorkoutType = WorkoutType.Strength;

var chestSupportedRowLog = new ExerciseLog();
chestSupportedRowLog.Exercise = chestSupportedRow;
chestSupportedRowLog.Sets.Add(new Set { Reps: 12, Weight = 36});
chestSupportedRowLog.Sets.Add(new Set { Reps: 10, Weight = 40});

session.ExerciseLog.Add(chestSupportedRowLog);
*/