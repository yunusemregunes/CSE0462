using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwcounter : MonoBehaviour
{
    public throwcounter2 cube2script;
    public throwcounter3 cube3script;
    public throwcounter4 cube4script;
    public int gthrowcount;
    public int gscore;

    public int throwcount1 = 0;
    public int score1=10;

    void OnTriggerEnter(Collider col)
    {
        gthrowcount=cube3script.throwcount3+cube2script.throwcount2+throwcount1+cube4script.throwcount4;
        gscore = score1+cube2script.score2+cube3script.score3+cube4script.score4;
        ScoreViewer.gscoreX=gscore;

        if (col.gameObject.name == "Yard"||col.gameObject.name == "Yard (1)")
        {
            throwcount1++;
            score1--;
            //Debug.Log("Try again, Attempt Number: " + gthrowcount);
            //Debug.Log("Score: " + gscore);
        }

    }

}