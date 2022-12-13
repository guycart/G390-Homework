/* using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayStack : MonoBehaviour
{
    Stack<Card> pile - new Stack<Card>();


    public List<Card> Flush()
    {
        if(pile.Count > 0)
        {
            Card lastPlayedCard = pile.Pop();
            List<Card> remainingCards = new List<Card>(pile);
            pile.Clear();
            pile.Push(lastPlayedCard);
            return new List<Card>(remainingCards);
        }
        else
        {
            Debug.LogWarning("The play stack was empty when flush was attempted");
            return new List<Card>();
        }
    }


    public void PlayCard(Card private void OnTransformChildrenChanged() {
        {
            pile.Push(card);
        }
    }

    public Card GetLastPlayedCard() => pile.Peek();
}
 */