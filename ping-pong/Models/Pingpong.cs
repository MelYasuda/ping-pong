using System;
using System.Collections.Generic;

namespace Pingpong
{
  public class PingpongGenerator
  {
    public bool ShowOutput(string input)
    {
      // if input is an empty string return false
        if (input == "")
        {
          return false;
        }
        else
        {
          return true;
        }
    }
  }
}
