### Class Planning

MuscleGroup     (enum)  Chest, Back, Legs, Shoulders, Arms...
WorkoutType     (enum)  Hypertrophy, Strength
ExerciseType    (enum)  Isolation, Compound

Exercise        Name, MuscleGroup, WorkoutType, ExerciseType, IsActive
Set             Reps, Weight
ExerciseLog     Exercise, List of Sets
WorkoutSession  Date, MuscleGroup, WorkoutType, List of ExerciseLogs



### Weeks
ISOWeek.GetWeekOfYear(date), or count weeks since first logged workout: "Week 1, Week 2…
Database writing or csv writing
We will determine what week we are in
We will tell the system when we are in a different week

### Type of workout
either hypertrophy or strength 


### Muscle Group > Exercises
For each muscle group we will have a set number of exercises we do and we will have named it hypertrophy (high reps, lower weigh) or strength set (lower reps, higher weight)

### Exercises > Sets, Reps and Weight
For each exercise we will have a set number of sets, inside sets we will have number of reps and weight we do, and if we increased or decreased the weight

### Exercise Type > Isolation vs Compound
Each exercise will also either be isolation or compound exercise.

### Record Taking

When we complete a workout we will specify what muscle group, then be prompted for each exercise:

How many reps and the weight per set? (separated by commas and X - 10x60, 8x65, 6x70)
The sets will calculate themselves
The system will keep separate records for separate muscle groups but also the same muscle groups and different type of workout (hyper or strength)

### The Overall System:
- The system will store raw data, calculate everything else later. 
	Workout things from the history when needed
	Writing methods that search and summarise data

- The system will record and write each workout under the week it is completed with all corresponding information (CSV first, database later)

### Changing Exercises
Then as a user we can also change our exercises for each muscle group at a later date. 

For example, it will save the exercises we do and their records, with ability to set as IsActive. We can mark old ones as false and then they are there if we ever want to return back to them. We will ask for the exercises that are active only when recording a workout.

