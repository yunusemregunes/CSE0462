using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucketCounter2 : MonoBehaviour
{
    public bucketCounter bucketscript;
    public bucketCounter3 bucketscript3;
    public bucketCounter4 bucketscript4;

    public int bucketcount2 = -1;
    public int score2 = 11;

    void OnTriggerEnter(Collider col)
    {
        int gthrowcount=bucketscript.bucketcount+bucketcount2+bucketscript3.bucketcount3+bucketscript4.bucketcount4;
        int gscore =bucketscript.score+score2+bucketscript3.score3+bucketscript4.score4;
        ScoreViewer3.gscoreX=gscore;
        if (col.gameObject.name == "bucketPlane")
        { 
            bucketcount2++;
            score2--;
        }

    }
}

