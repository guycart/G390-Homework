using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
  public int currency = 10;

  public int xp = 0;

  public int lives = 3;

  public void AddCurrency(int newCurrency)
  {
    currency += newCurrency;
  }

  public void AddXP(int newXP)
  {
    xp += newXP;
  }
}
