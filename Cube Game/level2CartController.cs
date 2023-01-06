using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2CartController : MonoBehaviour
{
    public manController script;
    [SerializeField] bool trigger;
    private float speed = 0.05f;
    private float waitingSpeed = 0.03f;
    //GameObject manObject;
    
    // Start is called before the first frame update
    void Start()
    {
       //manObject = GameObject.FindWithTag("Man");
    }

    // Update is called once per frame
    void Update()
    {
        int position = 7;
        
        if(trigger == true) {
            //Debug.Log("q"+script.animator.GetInteger("score"));
            script.animator.SetInteger("score", 10);
            //manObject.GetComponent<Animator>().SetInteger("score", 10);
           // transform.position = transform.position + new Vector3(speed * Time.deltaTime ,0,0);
            position += 1;
        }    
    }
}
