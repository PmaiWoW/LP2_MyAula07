﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventMaster : MonoBehaviour
{

    // The background image
    [SerializeField] private Texture background = null;
    [SerializeField] private int pressCount = 0;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) OnKeyPress('W');
        if (Input.GetKeyDown(KeyCode.S)) OnKeyPress('S');
        if (Input.GetKeyDown(KeyCode.A)) OnKeyPress('A');
        if (Input.GetKeyDown(KeyCode.D)) OnKeyPress('D');

        if (UnityEngine.Random.value < 0.001f)
            OnKeyPressMultiple(
                (char)UnityEngine.Random.Range(0, 100),
                UnityEngine.Random.Range(0, 1500));
    }

    // Use Unity's immediate mode GUI (IMGUI) to display information
    private void OnGUI()
    {
        // Set this GUI rendering to background
        GUI.depth = 1;

        // Draw background
        if (background != null)
            GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height),
            background, ScaleMode.StretchToFill);

        // Set default GUI color
        GUI.color = Color.white;

        // Show label for pressing keys
        GUI.Label(new Rect(10, 10, 200, 50), "Press W, S, A, D keys");
    }


    // This method triggers the event. It can only be called from this class
    // or subclasses
    protected virtual void OnKeyPress(char key)
    {
        if (KeyPress != null) KeyPress(this, new KeyEventArgs(key));
    }

    // Others can add or remove listeners to the key press event
    public event EventHandler<KeyEventArgs> KeyPress;

    [Serializable]
    public class MyUnityEvent : UnityEvent<char, int> { }

    protected virtual void OnKeyPressMultiple(char key, int value)
    {
        if (KeyPressMultiple != null) KeyPressMultiple.Invoke(key, value);
    }

    public MyUnityEvent KeyPressMultiple;
}
