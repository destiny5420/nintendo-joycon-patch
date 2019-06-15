using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PaperGmaeStudio.Controller;

public class DemoScript : MonoBehaviour
{
    string[] controlls;

    void Start()
    {
        NintendoJoyconManager.Init();
        NintendoJoyconManager.OnRegistCallback(NintendoJoyconManager.NINTENDO_KEY_TYPE.Player02_A, OnClick_A_02);
        NintendoJoyconManager.OnRegistCallback(NintendoJoyconManager.NINTENDO_KEY_TYPE.Player04_D, OnClick_D_04);
    }

    void OnClick_A_02(float v_value)
    {
        Debug.Log("OnClick_A_02 / value: " + v_value);
    }

    void OnClick_D_04(float v_value)
    {
        Debug.Log("OnClick_D_04 / value: " + v_value);
    }
}
