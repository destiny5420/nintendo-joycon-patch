using UnityEngine;
using PaperGmaeStudio.Controller;

public class DemoScript : MonoBehaviour
{
    void Start()
    {
        NintendoJoyconManager.Init();
        NintendoJoyconManager.RegistCallback(NintendoJoyconManager.NINTENDO_KEY_TYPE.Player01_A, OnClick_A_01);
    }

    void OnClick_A_01(float v_value)
    {
        Debug.Log("OnClick_A_01 / value: " + v_value);
    }
}
