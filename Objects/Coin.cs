using System.Collections.Generic;
using System;

namespace CoinCombo.Objects
{
  public class Coin
  {
    private int _cents;
    private static List<int> _remaindersObjects = new List<int>{};

    public Coin(int cents)
    {
      _cents = cents;
    }


    public int GetQuarters(int input)
    {
      int myQuarters = input / 25;
      int quarterRemainder = input % 25;
      _remaindersObjects.Add(quarterRemainder);

      return myQuarters;
    }
    public int GetDimes(int quarterRemainder)
    {
      int myDimes = quarterRemainder / 10;
      int dimeRemainder = quarterRemainder % 10;
      _remaindersObjects.Add(dimeRemainder);

      return myDimes;
    }
    public int GetNickles(int dimeRemainder)
    {
      int myNickles = dimeRemainder / 5;
      int nickleRemainder = dimeRemainder % 5;
      _remaindersObjects.Add(nickleRemainder);

      return myNickles;
    }
    public int GetPennies(int nickleRemainder)
    {
      int myPennies = nickleRemainder;

      return myPennies;
    }



    // public bool ChangeBack(int changeInput)
    // {
    //   if (changeInput == changeInput)
    //   {
    //     return true;
    //   }
    //
    // }
  }
}
