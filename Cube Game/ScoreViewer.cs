using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreViewer : MonoBehaviour
{
    public throwcounter scoreHolder; 
    public Text scoreText;
    public static int gscoreX;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        scoreText.text=gscoreX.ToString()+" POINTS";
    }
}
