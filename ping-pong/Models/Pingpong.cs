using System;
using System.Collections.Generic;

namespace Pingpong
{
  public class PingpongGenerator
  {
    public List<int> ShowOutput(string input)
    {
      List <int> list = new List<int>();
      // if input is an empty string return false
      if (input == "")
      {
        return list;
      }
      else
      {
        int parsedNumber = 0;
        bool parseResult = int.TryParse(input, out parsedNumber);
        if (parseResult == false)
        {
          return list;
        }
        else if (parsedNumber < 1)
        {
          return list;
        }
        else
        {
          for (int i = 1; i <= parsedNumber; i++)
          {
            if (i % 3 == 0)
            {
              list.Add(-1);
            }
            else
            {
              list.Add(i);
            }
          }
          return list;
        }
      }
    }
  }
}
