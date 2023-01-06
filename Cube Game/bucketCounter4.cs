using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucketCounter4 : MonoBehaviour
{
    public bucketCounter bucketscript;
    public bucketCounter3 bucketscript3;
    public bucketCounter2 bucketscript2;

    public int bucketcount4 = -1;
    public int score4 = 11;

    void OnTriggerEnter(Collider col)
    {
        int gthrowcount=bucketscript.bucketcount+bucketscript2.bucketcount2+bucketscript3.bucketcount3+bucketcount4;
        int gscore =bucketscript.score+bucketscript2.score2+bucketscript3.score3+score4;
        ScoreViewer3.gscoreX=gscore;
        if (col.gameObject.name == "bucketPlane")
        { 
            bucketcount4++;
            score4--;
        }

    }
}

