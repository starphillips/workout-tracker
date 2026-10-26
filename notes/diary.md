### Recap
- created the classes and enums aligned to the project's plan
- hardcoded some exercises in to test the relations between the classes and enums, printed out the values
- moved hardcoded exercises to the library. more loops to gather the users "active" exercises

### 19/10/2026

- Adding user input to the program. User can decide which muscle group they trained and will produce a list of exercises under that muscle group
    - Next Step: method to allow users to add their sets of reps and weight, parsing input first
    
- Parsing user input - checks whether it matches a muscle group defined in our enum, error handles and lets the user try again if an invalid entry is submitted


### 23/10/2026

- parse sets: a method which takes the user's input and converts it into int and decimal. This is so that we can determine the actual values for later when retrieving the users history e.g. personal bests and week tracking


### 26/10/2026
- cleaning up old comments and notes
- rewriting and adding validation to the parse sets method. bool return for user input at program.cs to determine the error printed
- user input for sets implemented, prints full exercise log after user has gone through all active exercises for that muscle group