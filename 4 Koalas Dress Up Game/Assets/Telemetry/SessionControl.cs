using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SessionControl : MonoBehaviour
{
    public void OnConnectionSuccess( int sessionID)
    {
        var displayField = GetComponent<TextMeshProUGUI>();

        if (sessionID < 0)
        {
            displayField.text = $"Logging locally(session {sessionID})";
        }
        else
        {
            displayField.text = $"connected to server (session {sessionID})";
        }
    }

    public void OnConnectionFail(string errorMessage)
    {
        var displayField = GetComponent<TextMeshProUGUI>();
        displayField.text = $"Error: {errorMessage}";
    }



}
