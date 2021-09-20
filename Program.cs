using System;
using System.Collections.Generic;

// input is int number, less than 100 -- for brevity
// test whether divisible by 5 & 3 --> ping-pong
// test whether divisible by 3 --> ping
// test whether divisible by 5 --> pong
// use a list to add results (output all as string?)

namespace PingPong
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Input a number between 1 and 100");
      string stringNumber = Console.ReadLine();
      int inputNumber = int.Parse(stringNumber);
      List<string> outputString = new List<string>(0);

      if (inputNumber >= 1 && inputNumber < 100) {
        for (int i = 1; i < inputNumber + 1; i++) {
          if ((i % 3 == 0) && (i % 5 == 0)) {
          outputString.Add("ping-pong");
          }
          else if (i % 3 == 0) {       
          outputString.Add("ping");
          }
          else if (i % 5 == 0) {           
          outputString.Add("pong");
          }
          else {
            outputString.Add(i.ToString());
          }
        }

      foreach (var j in outputString) 
        {
        Console.WriteLine(j);
        }
      }
      else {
      Console.WriteLine("Please enter a number between 1 - 100");
      }



    }
  }
}