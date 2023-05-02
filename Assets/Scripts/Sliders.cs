using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sliders : MonoBehaviour {
    public GameObject VariableImg;
    public GameObject WidthSlider;
    public GameObject HeightSlider;

    public void Change_Width()
    {
        float curentHeight = HeightSlider.GetComponent<Slider>().value;
        float curentWidth=WidthSlider.GetComponent<Slider>().value;
        VariableImg.transform.localScale = new Vector2(1f * curentWidth,curentHeight);
    }

    public void Change_Height() 
    {
        float curentWidth = WidthSlider.GetComponent<Slider>().value;
        float curentHeight=HeightSlider.GetComponent<Slider>().value;
        VariableImg.transform.localScale = new Vector2(curentWidth,1f * curentHeight);
    }

}
