using System;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleMessages : MonoBehaviour
{
    // Reference to the event master
    private EventMaster em;

    // Awake is called one time at the beginning
    private void Awake()
    {
        // Get reference to the event master
        em = GetComponent<EventMaster>();
    }

    private void OnEnable()
    {
        em.KeyPress += ShowConsoleMessage;
    }

    // Use this to remove event listeners
    private void OnDisable()
    {
        em.KeyPress -= ShowConsoleMessage;
    }

    private void ShowConsoleMessage(object sender, KeyEventArgs key)
    {
        switch (key.KeyPressed)
        {
            case 'W':
                Debug.Log("W was pressed!");
                break;
            case 'S':
                Debug.Log("S was pressed!");
                break;
            case 'A':
                Debug.Log("A was pressed!");
                break;
            case 'D':
                Debug.Log("D was pressed!");
                break;
        }
    }

    public void ShowSomethingWeird(char key, int number)
    {
        Debug.Log($"key is {key}, number is {number}.");
    }
}
