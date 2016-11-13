using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class QuickLog : MonoBehaviour 
{
    public Text _text;

	// Use this for initialization
	void Start () 
    {
        Application.logMessageReceived += onLogReceived;
	}

    private void onLogReceived(string condition, string stackTrace, LogType type)
    {
        if(_text != null)
        {
            _text.text = condition;
        }
    }
}
