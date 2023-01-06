using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucketCounter : MonoBehaviour
{
    public bucketCounter2 bucketscript2;
    public bucketCounter3 bucketscript3;
    public bucketCounter4 bucketscript4;
    public int gthrowcount;
    public int gscore;
    public int bucketcount = -1;
    public int score = 11;

    void OnTriggerEnter(Collider col)
    {
        gthrowcount=bucketcount+bucketscript2.bucketcount2+bucketscript3.bucketcount3+bucketscript4.bucketcount4;
        gscore =score+bucketscript2.score2+bucketscript3.score3+bucketscript4.score4;
        ScoreViewer3.gscoreX=gscore;
        if (col.gameObject.name == "bucketPlane")
        { 
            bucketcount++;
            score--;
            //Debug.Log("Try again, Attempt Number: " + gthrowcount);
            //Debug.Log("Score: " + gscore);
        }

    }
}

