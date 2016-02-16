using System;
using CoinCombo.Objects;
using Nancy;
using System.Collections.Generic;

namespace CoinCombo.Objects
{
  public class HomeModule : NancyModule
  {
      public HomeModule()
      {
        Get["/"] = _ =>{
          return View["index.cshtml"];
        };
        Post["/result"] = _ =>{
          Coin newCoin = new Coin(Request.Form["new-supercoolmegacoincounterthing"]);
          Dictionary<string, int> myDictionary = newCoin.GetChange();
          return View["result.cshtml",myDictionary];
        };

      }
  }
}
