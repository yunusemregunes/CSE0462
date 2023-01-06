using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwcounter3 : MonoBehaviour
{
        public throwcounter cubescript;
        public throwcounter2 cube2script;
        public throwcounter4 cube4script;
        public int gthrowcount;
        public int gscore;

    public int throwcount3 = -1;
    public int score3 = 11;

    void OnTriggerEnter(Collider col)
    {
        gthrowcount=throwcount3+cube2script.throwcount2+cubescript.throwcount1+cube4script.throwcount4;
        gscore = cubescript.score1+cube2script.score2+score3+cube4script.score4;
        ScoreViewer.gscoreX=gscore;
        if (col.gameObject.name == "Yard"||col.gameObject.name == "Yard (1)")
        { 
            throwcount3++;
            score3--;
        }

    }
}
