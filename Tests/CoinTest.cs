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

  }
}
