using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class WriteDebugToFile : MonoBehaviour
{
    string filename = "";

    void OnEnable()
    {
        Application.logMessageReceived += Log;
    }

    void OnDisable()
    {
        Application.logMessageReceived -= Log;
    }

    void Start()
    {
        filename = Application.dataPath + "/LogFile.text";
    }

    public void Log(string logString, string stackTrace, LogType type)
    {
        TextWriter tw = new StreamWriter(filename, true);
        tw.WriteLine(logString);
        tw.Close();
    }
}
