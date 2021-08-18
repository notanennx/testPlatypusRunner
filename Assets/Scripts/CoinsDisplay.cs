using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using DG.Tweening;

public class CoinsDisplay : MonoBehaviour
{
    public int coinsAmount = 0;
    public TMP_Text coinsText;

    // Awake
    public static CoinsDisplay i;
    void Awake()
    {
        i = this;
    }

    // Add
    public void AddCoins(int amount)
    {
        SetCoins(coinsAmount + amount);
    }

    // Set
    public void SetCoins(int amount)
    {
        coinsAmount = amount;
        UpdateLabel();
    }

    // Update
    private void UpdateLabel()
    {
        coinsText.text = coinsAmount.ToString();
        coinsText.rectTransform.DOPunchScale(new Vector3(1.05f, 1.05f, 1.05f), 0.3f, 4, 0.4f);
    }

}
