using System.Collections.Generic;
using System.Linq;

internal static class FromRomanNumerals
{
  public static int Convert(string romanNumber)
  {
    var sum = 0;
    var mapping = new Dictionary<char, int> {{'I', 1}, {'V', 5}, 
                               {'X', 10}, {'L', 50}, {'C', 100}, 
                               {'D', 500}, {'M', 1000}};
    var numbers = romanNumber.Select(x => mapping[x]).ToList();
    for (var i = 0; i < numbers.Count; i++)
    {
      var current = numbers[i];
      var next = i < numbers.Count - 1 ? numbers[i + 1] : 0;
      sum += next > current ? -current : current;
    }
    return sum;
  }
}