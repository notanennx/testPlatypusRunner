using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;
using UnityEngine.UI;

public class ProgressDisplay : MonoBehaviour
{
    public Image fillerImage;
    private int curProgress = 0;

    // Awake
    public static ProgressDisplay i;
    void Awake()
    {
        i = this;
    }

    // Progress
    public void Progress()
    {
        curProgress = Mathf.Min(curProgress + 1, Config.i.RoadAmount);
    
        // Fill
        float fillAmount = ((float)curProgress / (float)Config.i.RoadAmount);
        DOTween.To(x => fillerImage.fillAmount = x, fillerImage.fillAmount, fillAmount, 0.66f);

        // Stop
        if (curProgress >= Config.i.RoadAmount)
        {
            RoadManager.i.RoadStop();
        }
    }
}
