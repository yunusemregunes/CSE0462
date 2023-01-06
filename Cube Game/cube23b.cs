using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube23b : MonoBehaviour
{
    public cube21r script21r;
    public cube22b script22b;
    public cube22r script22r;
    public cube21b script21b;
    public cube23r script23r;
    public int throwcount23b = -1;
    public int score23b = 11;

    void OnTriggerEnter(Collider col)
    {
        int gthrowcount=script21b.throwcount21b+script21r.throwcount21r+script22b.throwcount22b+script22r.throwcount22r+throwcount23b+script23r.throwcount23r;
        int gscore=script21b.score21b+script21r.score21r+script22b.score22b+script22r.score22r+score23b+script23r.score23r;
        ScoreViewer2.gscoreX=gscore;
        if (col.gameObject.name == "GroundScore")
        {
            throwcount23b++;
            score23b--;
           //  Debug.Log("Score: " + gscore);
        }

    }
}
