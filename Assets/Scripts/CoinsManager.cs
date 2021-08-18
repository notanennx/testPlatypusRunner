using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;

public class CoinsManager : MonoBehaviour
{
    // Awake
    public static CoinsManager i;
    void Awake()
    {
        i = this;
    }

    // Collect
    public void Collect(GameObject coinObject)
    {
        Coin coinScript = coinObject.GetComponent<Coin>();
            CoinsDisplay.i.AddCoins(coinScript.value);

            coinObject.transform.DOMoveY(10f, 0.1f);
            Destroy(coinObject, 0.1f);
    }
}
