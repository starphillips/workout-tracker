// using System.Linq;
static class ExerciseLibrary
{
    public static List<Exercise> All = new List<Exercise>
    {
        new Exercise {Name = "Hip Thrusts", MuscleGroup = MuscleGroup.Glutes, ExerciseType = ExerciseType.Compound},
        new Exercise { Name = "Single Leg RDL", MuscleGroup = MuscleGroup.Glutes, ExerciseType = ExerciseType.Compound},
        new Exercise {Name = "Bulgarian Split Squats", MuscleGroup = MuscleGroup.Glutes, ExerciseType = ExerciseType.Compound},
        new Exercise {Name = "Cable Kickbacks", MuscleGroup = MuscleGroup.Glutes, ExerciseType = ExerciseType.Isolation},
        new Exercise {Name = "Abductors", MuscleGroup = MuscleGroup.Glutes, ExerciseType = ExerciseType.Isolation},

        new Exercise {Name = "Smith Machine Reverse Lunges", MuscleGroup = MuscleGroup.Legs, ExerciseType = ExerciseType.Compound},
        new Exercise {Name = "Single Leg Press", MuscleGroup = MuscleGroup.Legs, ExerciseType = ExerciseType.Compound},
        new Exercise {Name = "Leg Curls", MuscleGroup = MuscleGroup.Legs, ExerciseType = ExerciseType.Isolation},
        new Exercise {Name = "Leg Extensions", MuscleGroup = MuscleGroup.Legs, ExerciseType = ExerciseType.Isolation},
        new Exercise {Name = "Calve Raises", MuscleGroup = MuscleGroup.Legs, ExerciseType = ExerciseType.Isolation},
        new Exercise {Name = "Adductors", MuscleGroup = MuscleGroup.Legs, ExerciseType = ExerciseType.Isolation},

        new Exercise {Name = "Pull Ups", MuscleGroup = MuscleGroup.Back, ExerciseType = ExerciseType.Compound},
        new Exercise {Name = "Single Arm Pulldowns", MuscleGroup = MuscleGroup.Back, ExerciseType = ExerciseType.Compound},
        new Exercise {Name = "Chest Supported Rows", MuscleGroup = MuscleGroup.Back, ExerciseType = ExerciseType.Compound},
        new Exercise {Name = "Y Raises", MuscleGroup = MuscleGroup.Back, ExerciseType = ExerciseType.Isolation, IsActive = false},

        new Exercise {Name = "Cable Lateral Raises", MuscleGroup = MuscleGroup.Shoulders, ExerciseType = ExerciseType.Isolation},
        new Exercise {Name = "Face Pulls", MuscleGroup = MuscleGroup.Shoulders, ExerciseType = ExerciseType.Compound},
        new Exercise {Name = "Dumbbell Shoulder Press", MuscleGroup = MuscleGroup.Shoulders, ExerciseType = ExerciseType.Compound},
        new Exercise {Name = "Dumbbell Lateral Raises", MuscleGroup = MuscleGroup.Shoulders, ExerciseType = ExerciseType.Isolation, IsActive = false},

    };

    public static List<Exercise> GetActiveByMuscleGroup(MuscleGroup muscleGroup)
    {
        return All.Where(exercise => exercise.MuscleGroup == muscleGroup && exercise.IsActive).ToList();
    }

}

