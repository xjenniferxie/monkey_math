using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Required when Using UI elements.

public class AutoclickInput : MonoBehaviour
{

    public InputField inputField;

    // Use this for initialization
    public void Start()
    {
        inputField.ActivateInputField();
    }

    // Update is called once per frame
    void Update()
    {

    }
}