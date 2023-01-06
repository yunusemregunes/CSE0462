using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube22b : MonoBehaviour
{
    public cube21r script21r;
    public cube21b script21b;
    public cube22r script22r;
    public cube23b script23b;
    public cube23r script23r;
    public int throwcount22b = -1;
    public int score22b = 11;

    void OnTriggerEnter(Collider col)
    {
        int gthrowcount=script21b.throwcount21b+script21r.throwcount21r+throwcount22b+script22r.throwcount22r+script23b.throwcount23b+script23r.throwcount23r;
        int gscore=script21b.score21b+script21r.score21r+score22b+script22r.score22r+script23b.score23b+script23r.score23r;
        ScoreViewer2.gscoreX=gscore;
        if (col.gameObject.name == "GroundScore")
        {
            throwcount22b++;
            score22b--;
            // Debug.Log("Score: " + gscore);
        }

    }
}
