using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwcounter4 : MonoBehaviour
{
    public throwcounter cubescript;
    public throwcounter2 cube2script;
    public throwcounter3 cube3script;
    public int gthrowcount;
    public int gscore;
    public int throwcount4 = -1;
    public int score4 = 11;

    void OnTriggerEnter(Collider col)
    {
        gthrowcount=cube3script.throwcount3+cube2script.throwcount2+cubescript.throwcount1+throwcount4;
        gscore = cubescript.score1+cube2script.score2+cube3script.score3+score4;
        ScoreViewer.gscoreX=gscore;
        if (col.gameObject.name == "Yard"||col.gameObject.name == "Yard (1)")
        {
            throwcount4++;
            score4--;
        }

    }
}
