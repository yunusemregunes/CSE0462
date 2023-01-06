using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwcounter2 : MonoBehaviour
{
    public throwcounter cubescript;
    public throwcounter3 cube3script;
    public throwcounter4 cube4script;
    public int gthrowcount;
    public int gscore;

    public int throwcount2 = -1;
    public int score2 = 11;

    void OnTriggerEnter(Collider col)
    {
        gthrowcount=cube3script.throwcount3+throwcount2+cubescript.throwcount1+cube4script.throwcount4;
        gscore = cubescript.score1+score2+cube3script.score3+cube4script.score4;
        ScoreViewer.gscoreX=gscore;
        if (col.gameObject.name == "Yard"||col.gameObject.name == "Yard (1)")
        {
            throwcount2++;
            score2--;
        }

    }
}
