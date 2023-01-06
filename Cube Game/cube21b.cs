using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube21b : MonoBehaviour
{
    public cube21r script21r;
    public cube22b script22b;
    public cube22r script22r;
    public cube23b script23b;
    public cube23r script23r;

    public int throwcount21b = -1;
    public int score21b = 10;
    public int gthrowcount;
    public int gscore;

    void OnTriggerEnter(Collider col)
    {
        gthrowcount=throwcount21b+script21r.throwcount21r+script22b.throwcount22b+script22r.throwcount22r+script23b.throwcount23b+script23r.throwcount23r;
        gscore=score21b+script21r.score21r+script22b.score22b+script22r.score22r+script23b.score23b+script23r.score23r;
        ScoreViewer2.gscoreX=gscore;
        if (col.gameObject.name == "GroundScore")
        {
            score21b--;
            throwcount21b++;
            //Debug.Log("Try again Attempt Number: " + gthrowcount);
            //Debug.Log("Score: " + gscore);

        }

    }
}
