class Set
{
   public int Reps;
   public double Weight;

   public static List<Set> ParseSets(string input)
   {
      List<Set> sets = new List<Set>();
      var setArray = input.Split(",");

      foreach (string i in setArray) 
      {
         string[] test = i.Trim().Split("x");

          int rep = int.Parse(test[0]);
          double weight = float.Parse(test[1]);
         // Console.WriteLine($"reps: {test[0]}, weight: {test[1]}");

         sets.Add(new Set {Reps = rep, Weight = weight});
      }
      return sets;
   }
}
