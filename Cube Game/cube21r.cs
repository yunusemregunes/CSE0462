using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube21r : MonoBehaviour
{
    public cube21b script21b;
    public cube22b script22b;
    public cube22r script22r;
    public cube23b script23b;
    public cube23r script23r;
    public int throwcount21r = -1;
    public int score21r = 11;

    void OnTriggerEnter(Collider col)
    {
        int gthrowcount=script21b.throwcount21b+throwcount21r+script22b.throwcount22b+script22r.throwcount22r+script23b.throwcount23b+script23r.throwcount23r;
        int gscore=script21b.score21b+score21r+script22b.score22b+script22r.score22r+script23b.score23b+script23r.score23r;
        ScoreViewer2.gscoreX=gscore;
        if (col.gameObject.name == "GroundScore")
        {
            throwcount21r++;
            score21r--;
             //Debug.Log("Score: " + gscore);
        }

    }
}
