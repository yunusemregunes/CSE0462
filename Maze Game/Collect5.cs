using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect5 : MonoBehaviour
{
    public GameHandler GH;
    //public AudioClip itemSound;

    void Start()
    {

        GH = GameObject.Find("Canvas").GetComponent<GameHandler>();

    }



    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("Collectible"))
        {
            Debug.Log("Item Collected");
            GH.items++;
            Debug.Log("Collected items:" + GH.items);
            //AudioSource.PlayClipAtPoint(itemSound, transform.position);
            Destroy(other.gameObject);
            Debug.Log("Level 5 Points: " + GH.items * 10);

        }

    }
}
