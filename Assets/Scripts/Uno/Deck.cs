using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public List<Card> cardCollection = new List<Card>();

    public Stack<Card> deck = new Stack<Card>();

    public PlayStack playStack;

    public UnityEvent PostDeckGenerated;

    private void private void Start()
        {
            drawPile.PostDeckGenerated.AddListener(DrawStart);
        }
    }
    
    void GenerateCardsForDeck()
    {
        for (int i = 0; i < 4; i++)
        {
            Card newCard = new Card(i, color);
                Card newCard = new Card();
                cardCollection.Add(newCard);
        }
    }

    foreach(CardColor color in System.Enum.GetValues(typeof(CardColor)))
    {
        for (int i = 0; i <= 9, i++)
        {
            Card newCard = new Card(i, color);
            cardCollection.Add(newCard);
        }
        print(cardCollection.Count);
        deck = ShuffleDeck(cardCollection);
    }

    Stack<Card> ShuffleDeck(List<Card> incomingDeck)
    {
        Stack<Card> newDecl = new Stack<Card>();

        int loopAttempts = 0;
        while(incomingDeck.Count > 0 && loopAttempts < 100)
        {
            int cardIndex = Random.range(0, incomingDeck.Count);
            newDeck.Push(incomingDeck[cardIndex]);
            incomingDeck.Remoce(newDeck.Peek());
            loopAttempts++;
        }
    }

    public Card DrawCard()
    {
        if(deck.Count == 0)
        {
            deck = ShuffleDeck(PlayStack.Flush());
        }
    
    
}


