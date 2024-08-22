using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Stats")]
    private int _health = 10;

    [Header("Cards")]
    public Character SelectedCharacter;
    private Card[] _deck;
    private List<Card> _hand = new List<Card>();
}
