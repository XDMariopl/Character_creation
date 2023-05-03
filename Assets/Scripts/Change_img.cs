using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change_img : MonoBehaviour {
    public Sprite[] HatMas;
    public Sprite[] ShirtMas;
    public Sprite[] PantsMas;
    public Sprite[] ShoesMas;
    public Sprite[] CharMas;
    public GameObject VariableImg;
    public GameObject FemaleToggle;
    public GameObject MaleToggle;
    public GameObject HatToggle;
    public GameObject ShirtToggle;
    public GameObject PantsToggle;
    public GameObject ShoesToggle;
    private bool gender;

    public void characterToggle(bool gender)
    {
        VariableImg.SetActive(gender);
        FemaleToggle.GetComponent<Toggle>().interactable = gender;
        MaleToggle.GetComponent<Toggle>().interactable = gender;
    }
    public void Male()
    {
        VariableImg.GetComponent<Image>().sprite = CharMas[0];
    }
    public void Female()
    {
        VariableImg.GetComponent<Image>().sprite = CharMas[1];
    }
    
    public void StyleToggle()
    {

    }

}
