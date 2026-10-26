class Set
{
   public int Reps;
   public double Weight;

   public static bool TryParseSets(string input, out List<Set> sets, out string error)
   {
      sets = new List<Set>();
      error = "";
      var setString = input.ToLower().Split(",");

      foreach (string i in setString)
      {
         string[] splitSet = i.Trim().Split("x");

         if (splitSet.Length != 2)
         {
            error = "please enter your sets, e.g. 12x40, 10x45";
            return false;
         }

         if(!int.TryParse(splitSet[0], out int rep))
         {
            error = $"'{splitSet[0]}' should be a number";
            return false;
         }

         if(!double.TryParse(splitSet[1], out double weight))
         {
            error = $"'{splitSet[1]}' should be a number, it can be decimal";
            return false;
         }

         if (rep <= 0 || weight < 0)
         {
            error = "reps must be above 0 and weight can't be negative";
            return false;
         }

         sets.Add(new Set {Reps = rep, Weight = weight});
      }
      return true;
   }
}

 