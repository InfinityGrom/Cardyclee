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
    
    public TextMeshPro cardName;
    public TextMeshPro cardCost;
    public TextMeshPro cardHp;
    public TextMeshPro cardAttack;
    
    Sprite image;

    

}
