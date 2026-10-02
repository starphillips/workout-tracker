# workout-tracker


Basic version: Create a Workout class with properties like Exercise, Sets, Reps, Weight, and Date. Let the user add entries through a menu loop (a while loop with a switch) and print them out.

Input validation: Use int.TryParse or try/catch around int.Parse so typing "ten" instead of "10" doesn't crash the program. This is where your exceptions knowledge comes in.

Saving to a file: Write workouts to a .txt or .csv file with File.AppendAllText, and load them back when the program starts. Handle the case where the file doesn't exist yet.

Useful features: Show your personal record for each exercise, total volume (sets × reps × weight) per session, or progress over time for one lift.

Stretch goals: Learn List<T> and LINQ (the natural next topics after W3Schools), add an enum for muscle groups, or use an interface like IExercise with subclasses for StrengthExercise and CardioExercise to practise inheritance and polymorphism.