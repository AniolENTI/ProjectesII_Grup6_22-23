using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EssenceBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public void SetMaxEssence(int maxEssence, int essence)
    {
        slider.maxValue = maxEssence;
        slider.value = essence;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
    public void SetEssence(int essence)
    {
        slider.value = essence;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
