using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GradientProgressbar : MonoBehaviour
{
    [SerializeField] Gradient colorBarGradient;
    [SerializeField] Image fillImage;
    Slider slide;
    // Start is called before the first frame update
    void Start()
    {
        slide = GetComponent<Slider>();
        RefreshColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void RefreshColor()
    {
        Debug.Log(slide.value);
        float slideCall = slide.value / slide.maxValue;
        fillImage.color = colorBarGradient.Evaluate(slideCall);
    }
}
