using System.Diagnostics.CodeAnalysis;
using System.Dynamic;

var hipThrusts = new Exercise{ Name = "Hip Thrusts", MuscleGroup = MuscleGroup.Glutes, ExerciseType = ExerciseType.Compound};

var singleLegRDLs = new Exercise { Name = "Single Leg RDLs", MuscleGroup = MuscleGroup.Glutes, ExerciseType = ExerciseType.Compound};

var bulgarianSplitSquats = new Exercise {Name = "Bulgarian Split Squats", MuscleGroup = MuscleGroup.Glutes, ExerciseType = ExerciseType.Compound};

var cableKickbacks = new Exercise {Name = "Cable Kickbacks", MuscleGroup = MuscleGroup.Glutes, ExerciseType = ExerciseType.Isolation};

var session = new WorkoutSession {
    MuscleGroup = MuscleGroup.Glutes, 
    WorkoutType = WorkoutType.Strength,
    ExerciseLogs =
    {
        new ExerciseLog
        {
            Exercise = bulgarianSplitSquats,
            Sets = {new Set {Reps = 8, Weight = 16}, new Set {Reps = 8, Weight = 16}, new Set {Reps = 8, Weight = 16}}
        },
        new ExerciseLog
        {
            Exercise = cableKickbacks,
            Sets = {new Set {Reps = 12, Weight = 14}, new Set {Reps = 12, Weight = 14}, new Set {Reps = 10, Weight = 14}}
        }
    },

};

var hpLog = new ExerciseLog { Exercise = hipThrusts};
hpLog.Sets.Add(new Set { Reps = 8, Weight = 42.5});
hpLog.Sets.Add(new Set { Reps = 8, Weight = 42.5});
hpLog.Sets.Add(new Set { Reps = 8, Weight = 42.5});

var rdlLog = new ExerciseLog { Exercise = singleLegRDLs};
rdlLog.Sets.Add(new Set { Reps = 12, Weight = 32});
rdlLog.Sets.Add(new Set { Reps = 8, Weight = 34});
rdlLog.Sets.Add(new Set { Reps = 8, Weight = 34});

session.ExerciseLogs.Add(hpLog);
session.ExerciseLogs.Add(rdlLog);

// Console.WriteLine(session.ExerciseLog);
Console.WriteLine($"{hpLog.Sets}, {rdlLog.Sets}");

Console.WriteLine($"{session.Date} – {session.MuscleGroup} ({session.WorkoutType})");

foreach (var exerciseLog in session.ExerciseLogs)
{
    Console.WriteLine($"  {exerciseLog.Exercise.Name}");
    // inner loop: go through exerciseLog.Sets and print each one like "    Set 1: 8 x 42.5kg"
}
// Console.WriteLine($"{Name}, {MuscleGroup}, {WorkoutType}");
