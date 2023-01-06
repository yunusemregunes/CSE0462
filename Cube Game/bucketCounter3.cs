using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucketCounter3 : MonoBehaviour
{
    public bucketCounter bucketscript;
    public bucketCounter2 bucketscript2;
    public bucketCounter4 bucketscript4;

    public int bucketcount3 = -1;
    public int score3 = 11;

    void OnTriggerEnter(Collider col)
    {
        int gthrowcount=bucketscript.bucketcount+bucketscript2.bucketcount2+bucketcount3+bucketscript4.bucketcount4;
        int gscore =bucketscript.score+bucketscript2.score2+score3+bucketscript4.score4;
        ScoreViewer3.gscoreX=gscore;
        if (col.gameObject.name == "bucketPlane")
        { 
            bucketcount3++;
            score3--;
        }

    }
}
