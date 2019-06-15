using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joystick : MonoBehaviour
{
    string[] controlls;

    void Start()
    {

    }

    void Update()
    {
        controlls = Input.GetJoystickNames();

        Debug.Log(" == controll count: " + controlls.Length);

        for (int i = 0; i < controlls.Length; i++)
            Debug.LogWarning("controlls["+i+"]: " + controlls[i]);

        for (int i = 0; i < controlls.Length; i++)
        {
            int iPlayerID = i + 1;

            if (Input.GetAxis(iPlayerID + "P_Horizontal") != 0)
                Debug.Log(iPlayerID + "P_Horizontal: " + Input.GetAxis(iPlayerID + "P_Horizontal"));

            if (Input.GetAxis(iPlayerID + "P_Vertical") != 0)
                Debug.Log(iPlayerID + "P_Vertical: " + Input.GetAxis(iPlayerID + "P_Vertical"));

            if (Input.GetAxis(iPlayerID + "P_A") >= 1.0f)
                Debug.Log(iPlayerID + "P_A");

            if (Input.GetAxis(iPlayerID + "P_B") >= 1.0f)
                Debug.Log(iPlayerID + "P_B");

            if (Input.GetAxis(iPlayerID + "P_C") >= 1.0f)
                Debug.Log(iPlayerID + "P_C");

            if (Input.GetAxis(iPlayerID + "P_D") >= 1.0f)
                Debug.Log(iPlayerID + "P_D");

        }

        //if (Input.GetAxis("1P_Horizontal") != 0)
        //    Debug.Log("1P_Horizontal: " + Input.GetAxis("1P_Horizontal"));

        //if (Input.GetAxis("1P_Vertical") != 0)
        //    Debug.Log("1P_Vertical: " + Input.GetAxis("1P_Vertical"));

        //if (Input.GetAxis("1P_A") >= 1.0f)
        //    Debug.Log("1P_A");

        //if (Input.GetAxis("1P_B") >= 1.0f)
        //    Debug.Log("1P_B");

        //if (Input.GetAxis("1P_C") >= 1.0f)
        //    Debug.Log("1P_C");

        //if (Input.GetAxis("1P_D") >= 1.0f)
        //    Debug.Log("1P_D");



        //if (Input.GetAxis("2P_Horizontal") != 0)
        //    Debug.Log("2P_Horizontal: " + Input.GetAxis("2P_Horizontal"));

        //if (Input.GetAxis("2P_Vertical") != 0)
        //    Debug.Log("2P_Vertical: " + Input.GetAxis("2P_Vertical"));

        //if (Input.GetAxis("2P_A") >= 1.0f)
        //    Debug.Log("2P_A");

        //if (Input.GetAxis("2P_B") >= 1.0f)
        //    Debug.Log("2P_B");

        //if (Input.GetAxis("2P_C") >= 1.0f)
        //    Debug.Log("2P_C");

        //if (Input.GetAxis("2P_D") >= 1.0f)
        //    Debug.Log("2P_D");


        //if (Input.GetAxis("3P_Horizontal") != 0)
        //    Debug.Log("3P_Horizontal: " + Input.GetAxis("3P_Horizontal"));

        //if (Input.GetAxis("3P_Vertical") != 0)
        //    Debug.Log("3P_Vertical: " + Input.GetAxis("3P_Vertical"));

        //if (Input.GetAxis("3P_A") >= 1.0f)
        //    Debug.Log("3P_A");

        //if (Input.GetAxis("3P_B") >= 1.0f)
        //    Debug.Log("3P_B");

        //if (Input.GetAxis("3P_C") >= 1.0f)
        //    Debug.Log("3P_C");

        //if (Input.GetAxis("3P_D") >= 1.0f)
        //    Debug.Log("3P_D");

        //if (Input.GetAxis("4P_Horizontal") != 0)
        //    Debug.Log("4P_Horizontal: " + Input.GetAxis("4P_Horizontal"));

        //if (Input.GetAxis("4P_Vertical") != 0)
        //    Debug.Log("4P_Vertical: " + Input.GetAxis("4P_Vertical"));

        //if (Input.GetAxis("4P_A") >= 1.0f)
        //    Debug.Log("4P_A");

        //if (Input.GetAxis("4P_B") >= 1.0f)
        //    Debug.Log("4P_B");

        //if (Input.GetAxis("4P_C") >= 1.0f)
        //    Debug.Log("4P_C");

        //if (Input.GetAxis("4P_D") >= 1.0f)
            //Debug.Log("4P_D");
    }
}
