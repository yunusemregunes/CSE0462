using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube22r : MonoBehaviour
{
    public cube21r script21r;
    public cube22b script22b;
    public cube21b script21b;
    public cube23b script23b;
    public cube23r script23r;
    public int throwcount22r = -1;
    public int score22r = 11;

    void OnTriggerEnter(Collider col)
    {
        int gthrowcount=script21b.throwcount21b+script21r.throwcount21r+script22b.throwcount22b+throwcount22r+script23b.throwcount23b+script23r.throwcount23r;
        int gscore=script21b.score21b+script21r.score21r+script22b.score22b+score22r+script23b.score23b+script23r.score23r;
        ScoreViewer2.gscoreX=gscore;
        if (col.gameObject.name == "GroundScore")
        {
            throwcount22r++;
            score22r--;
             //Debug.Log("Score: " + gscore);
        }

    }
}
