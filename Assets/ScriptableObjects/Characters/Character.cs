using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "Assets/Character")]
public class Character : MonoBehaviour
{
    public string Name;
    public DeckCards[] Deck;
}


[Serializable]
public struct DeckCards
{
    public Card Card;
    public int Qty;

    public DeckCards(Card card, int qty)
    {
        Card = card;
        Qty = qty;
    }
}
