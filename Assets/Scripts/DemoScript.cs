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
        NintendoJoyconManager.RegistCallback(NintendoJoyconManager.NINTENDO_KEY_TYPE.Player01_A, OnClick_A_01);
        NintendoJoyconManager.RegistCallback(NintendoJoyconManager.NINTENDO_KEY_TYPE.Player01_B, OnClick_B_01);
        NintendoJoyconManager.RegistCallback(NintendoJoyconManager.NINTENDO_KEY_TYPE.Player01_Y, OnClick_Y_01);
        NintendoJoyconManager.RegistCallback(NintendoJoyconManager.NINTENDO_KEY_TYPE.Player01_X, OnClick_X_01);
    }

    void OnClick_A_01(float v_value)
    {
        Debug.Log("OnClick_A_01 / value: " + v_value);
    }

    void OnClick_B_01(float v_value)
    {
        Debug.Log("OnClick_B_01 / value: " + v_value);
    }

    void OnClick_Y_01(float v_value)
    {
        Debug.Log("OnClick_Y_01 / value: " + v_value);
    }

    void OnClick_X_01(float v_value)
    {
        Debug.Log("OnClick_X_01 / value: " + v_value);
    }
}
