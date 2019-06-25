using UnityEngine;
using PaperGmaeStudio.Controller;

public class DemoScript : MonoBehaviour
{
    void Start()
    {
        NintendoJoyconManager.Init();
        NintendoJoyconManager.RegistCallback(NintendoJoyconManager.NINTENDO_KEY_TYPE.Player01_A, OnClick_A_01);
        NintendoJoyconManager.RegistCallback(NintendoJoyconManager.NINTENDO_KEY_TYPE.Player01_B, OnClick_B_01);
        NintendoJoyconManager.RegistCallback(NintendoJoyconManager.NINTENDO_KEY_TYPE.Player01_X, OnClick_X_01);
        NintendoJoyconManager.RegistCallback(NintendoJoyconManager.NINTENDO_KEY_TYPE.Player01_Y, OnClick_Y_01);
        NintendoJoyconManager.RegistCallback(NintendoJoyconManager.NINTENDO_KEY_TYPE.Player01_Horizontal, OnClick_Horizontal_01);
        NintendoJoyconManager.RegistCallback(NintendoJoyconManager.NINTENDO_KEY_TYPE.Player01_Vertical, OnClick_Vertical_01);
    }

    void OnClick_A_01(float v_value)
    {
        Debug.Log("OnClick_A_01 / value: " + v_value);
    }

    void OnClick_B_01(float v_value)
    {
        Debug.Log("OnClick_B_01 / value: " + v_value);
    }

    void OnClick_C_01(float v_value)
    {
        Debug.Log("OnClick_C_01 / value: " + v_value);
    }

    void OnClick_D_01(float v_value)
    {
        Debug.Log("OnClick_D_01 / value: " + v_value);
    }

    void OnClick_SL_01(float v_value)
    {
        Debug.Log("OnClick_SL_01 / value: " + v_value);
    }

    void OnClick_SR_01(float v_value)
    {
        Debug.Log("OnClick_SR_01 / value: " + v_value);
    }

    void OnClick_EXTRA_01_01(float v_value)
    {
        Debug.Log("OnClick_EXTRA_01_01 / value: " + v_value);
    }

    void OnClick_EXTRA_02_01(float v_value)
    {
        Debug.Log("OnClick_EXTRA_02_01 / value: " + v_value);
    }

    void OnClick_Horizontal_01(float v_value)
    {
        Debug.Log("OnClick_Horizontal_01 / value: " + v_value);
    }

    void OnClick_Vertical_01(float v_value)
    {
        Debug.Log("OnClick_Vertical_01 / value: " + v_value);
    }
}
