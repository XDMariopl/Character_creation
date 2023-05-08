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
    
    public void HatStyles(bool HatOnOff)
    {
        HatDropdown.GetComponent<Dropdown>().interactable=HatOnOff;
        HatImg.gameObject.SetActive(HatOnOff);
        
    }

    public void ShirtStyles(bool ShirtOnOff)
    {
        ShirtDropdown.GetComponent<Dropdown>().interactable=ShirtOnOff;
        ShirtImg.gameObject.SetActive(ShirtOnOff);
    }
    public void PantsStyles(bool PantsOnOff)
    {
        PantsDropdown.GetComponent<Dropdown>().interactable=PantsOnOff;
        PantsImg.gameObject.SetActive(PantsOnOff);
    }
    public void ShoesStyles(bool ShoesOnOff)
    {
        ShoesDropdown.GetComponent<Dropdown>().interactable=ShoesOnOff;
        ShoesImg.gameObject.SetActive(ShoesOnOff);
    }

}
