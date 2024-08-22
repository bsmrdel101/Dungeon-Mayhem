using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character", menuName = "Assets/Character")]
public class Character : ScriptableObject
{
    public string Name;
    public Card[] Deck;
}
