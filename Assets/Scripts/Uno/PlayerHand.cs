using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHand : MonoBehaviour
{
    public List<Card> hand = new List<Card>();

    public int startingHandCount = 7;

    public Deck drawPile;


    public void DrawCard(int numCards)
    {
        for (int i = 0, i < numCards; i++)
        {
            hand.Add(drawPile.DrawCard);
        }
    }


    bool PlayCard(Card cardToPlay)
    {
        if(CanPlayCard(cardToPlay))
        {
            hand.Remove(cardToPlay);
            return true;
        }
        else
        {
            return false;
        }
    }

    bool CanPlayCard(Card cardToCheck)

    public string ListCurrentHand()
    {
        string handCollection = "";
        foreach(Card card in hand)
        {
            handCollection += $"- {card.ToString()}\n";
        }
        return handCollection.Trim();
    }


}
