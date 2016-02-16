using System.Collections.Generic;
using Xunit;
namespace CoinCombo.Objects
{
  public class CoinComboTest
  {
    [Fact]
    public void Test1_GetAmountOfQuarters_ReturnAmount()
    {
      //Arrange
      Coin newCoins = new Coin(199);
      Assert.Equal(7, newCoins.GetQuarters(199));
    }

    [Fact]
    public void Test1_GetAmountOfDIMES_ReturnAmount()
    {
      //Arrange
      Coin newCoins = new Coin(199);
      Assert.Equal(19, newCoins.GetDimes(199));
    }
    [Fact]
    public void Test1_GetAmountOfNICKLES_ReturnAmount()
    {
      //Arrange
      Coin newCoins = new Coin(199);
      Assert.Equal(39, newCoins.GetNickles(199));
    }
    [Fact]
    public void Test1_GetAmountOfPENNIES_ReturnAmount()
    {
      //Arrange
      Coin newCoins = new Coin(199);
      Assert.Equal(199, newCoins.GetPennies(199));
    }
    [Fact]
    public void TestGetChange()
    {
      Coin newCoins = new Coin(180);
      Dictionary<string,int> testResults = new Dictionary<string,int>();
      testResults.Add("quarters", 7);
      testResults.Add("dimes", 0);
      testResults.Add("nickels", 1);
      testResults.Add("pennies", 0);
      Assert.Equal(testResults, newCoins.GetChange());
    }
  }
}
