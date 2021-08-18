using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;
using UnityEngine.UI;

public class ProgressDisplay : MonoBehaviour
{
    public Image fillerImage;
    public int curProgress = 0;
    public int maxProgress = 8;

    // Awake
    public static ProgressDisplay i;
    void Awake()
    {
        i = this;
    }

    // Progress
    public void Progress()
    {
        curProgress = Mathf.Min(curProgress + 1, maxProgress);
    
        // Fill
        float fillAmount = ((float)curProgress / (float)maxProgress);
        DOTween.To(x => fillerImage.fillAmount = x, fillerImage.fillAmount, fillAmount, 0.66f);

        // Stop
        if (curProgress >= maxProgress)
        {
            RoadManager.i.RoadStop();
        }
    }
}
