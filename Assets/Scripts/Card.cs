using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName ="Card")]
public class Card : ScriptableObject 
{
    public int id;
    public int maxHp;
    public int energy;
    public int attack;
    
    public string cardName;
    public string description;
    
    public Sprite image;

    

}
