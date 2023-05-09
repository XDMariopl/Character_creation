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
    public GameObject HatImg;
    public GameObject HatToggle;
    public GameObject HatDropdown;
    public GameObject ShirtImg;
    public GameObject ShirtToggle;
    public GameObject ShirtDropdown;
    public GameObject PantsImg;
    public GameObject PantsToggle;
    public GameObject PantsDropdown;
    public GameObject ShoesImg;
    public GameObject ShoesToggle;
    public GameObject ShoesDropdown;
    private bool gender;
    private bool HatOnOff;
    private bool ShirtOnOff;
    private bool PantsOnOff;
    private bool ShoesOnOff;

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
    
    public void HatActive(bool HatOnOff)
    {
        HatDropdown.GetComponent<Dropdown>().interactable=HatOnOff;
        HatImg.gameObject.SetActive(HatOnOff);
        
    }

    public void ShirtActive(bool ShirtOnOff)
    {
        ShirtDropdown.GetComponent<Dropdown>().interactable=ShirtOnOff;
        ShirtImg.gameObject.SetActive(ShirtOnOff);
    }
    public void PantsActive(bool PantsOnOff)
    {
        PantsDropdown.GetComponent<Dropdown>().interactable=PantsOnOff;
        PantsImg.gameObject.SetActive(PantsOnOff);
    }
    public void ShoesActive(bool ShoesOnOff)
    {
        ShoesDropdown.GetComponent<Dropdown>().interactable=ShoesOnOff;
        ShoesImg.gameObject.SetActive(ShoesOnOff);
    }

    public void HatStyles(int number)
    {
        if(number==0) { HatImg.GetComponent<Image>().sprite = HatMas[0]; }
        if (number == 1) { HatImg.GetComponent<Image>().sprite= HatMas[1]; }
        if (number == 2) { HatImg.GetComponent<Image>().sprite = HatMas[2]; }
    }

    public void ShirtStyles(int number)
    {
        if (number == 0) { ShirtImg.GetComponent<Image>().sprite = ShirtMas[0]; }
        if (number == 1) { ShirtImg.GetComponent<Image>().sprite = ShirtMas[1]; }
        if (number == 2) { ShirtImg.GetComponent<Image>().sprite = ShirtMas[2]; }
    }

    public void PantsStyles(int number)
    {
        if (number == 0) { PantsImg.GetComponent<Image>().sprite = PantsMas[0]; }
        if (number == 1) { PantsImg.GetComponent<Image>().sprite = PantsMas[1]; }
        if (number == 2) { PantsImg.GetComponent<Image>().sprite = PantsMas[2]; }
    }

    public void ShoesStyles(int number)
    {
        if (number == 0) { ShoesImg.GetComponent<Image>().sprite = ShoesMas[0]; }
        if (number == 1) { ShoesImg.GetComponent<Image>().sprite = ShoesMas[1]; }
        if (number == 2) { ShoesImg.GetComponent<Image>().sprite = ShoesMas[2]; }
    }

}
