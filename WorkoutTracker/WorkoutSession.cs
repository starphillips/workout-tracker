using System.Globalization;
class WorkoutSession
{
    public DateOnly Date = DateOnly.FromDateTime(DateTime.Today);
    public MuscleGroup MuscleGroup;
    public WorkoutType WorkoutType;
    public List<ExerciseLog> ExerciseLogs = new();
}