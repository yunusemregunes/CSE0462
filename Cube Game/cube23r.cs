using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube23r : MonoBehaviour
{
    public cube21r script21r;
    public cube22b script22b;
    public cube22r script22r;
    public cube23b script23b;
    public cube21b script21b;
    public int throwcount23r = -1;
    public int score23r = 11;

    void OnTriggerEnter(Collider col)
    {
        int gthrowcount=script21b.throwcount21b+script21r.throwcount21r+script22b.throwcount22b+script22r.throwcount22r+script23b.throwcount23b+throwcount23r;
        int gscore=script21b.score21b+script21r.score21r+script22b.score22b+script22r.score22r+script23b.score23b+score23r;
        ScoreViewer2.gscoreX=gscore;
        if (col.gameObject.name == "GroundScore")
        {
            throwcount23r++;
            score23r--;
            // Debug.Log("Score: " + gscore);
        }

    }
}
