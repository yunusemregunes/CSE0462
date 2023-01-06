using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basketMove : MonoBehaviour
{
    public loadScene script;
    GameObject obj1;
    private float speed = 0.35f;
    private float waitingSpeed = 0.03f;
    void Awake(){
        obj1=GameObject.FindGameObjectWithTag("inBasket");
    }

    // Update is called once per frame
    void Start()
    {
        Vector3 positions = transform.position;
    }

    void Update()
    {
        int position = 7;
        if(obj1.GetComponent<loadScene>().ctr == 0) {           
            transform.position = transform.position + new Vector3( 0,0,speed * Time.deltaTime);
            position += 1;
        }    
        
    }
}
