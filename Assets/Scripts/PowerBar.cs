using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PowerBar : MonoBehaviour
{
    public Image bar;
    public float sost;
    [SerializeField]public static float fill;
    public static float constEn = 0.1F;
    public static bool Con;
    void Start()
    {
        fill = 1;
    }

    void Update()
    {
        sost = fill;
        bar.fillAmount = fill;
        if (Con == true)
        {
            fill = fill - Time.deltaTime * constEn;
            if (fill <= 0)
            {
                fill = 0;
            }
        }
        if (Con == false)
        {
            fill = fill + (Time.deltaTime * constEn) * 0.5F;
            if (fill >= 1)
            {
                fill = 1;
            }
        }
    }
}
