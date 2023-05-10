using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_smt : MonoBehaviour {
    private int lvl;
    private string txt;
    public GameObject TxtInput;
    public GameObject LvlInput;
    public GameObject output;

    public void ShowTxt()
    {
        txt=TxtInput.GetComponent<InputField>().text;
        lvl = Int32.Parse(LvlInput.GetComponent<InputField>().text);
        if(txt!="")
        {
            if(lvl>0)
            {
                output.GetComponent<Text>().text = txt+" is currently at level "+lvl;
            }
            else
            {
                output.GetComponent<Text>().text = "Please enter your character lvl correctly.";
            }
        }
        else
        {
            output.GetComponent<Text>().text = "Please enter your character name and lvl correctly.";
        }

    }
}
