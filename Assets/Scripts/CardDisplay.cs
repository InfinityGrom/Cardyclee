using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour 
{
    public Card card;
    public int cardId;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;

    public Image art;

    public TextMeshProUGUI costText;
    public TextMeshProUGUI hpText;
    public TextMeshProUGUI attackText;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = card.cardName;
        descriptionText.text = card.description;
        
        art.sprite = card.image;

        costText.text = card.energy.ToString();
        hpText.text = card.maxHp.ToString();
        attackText.text = card.attack.ToString();
    }

    
}
