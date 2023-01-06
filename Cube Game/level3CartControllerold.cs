using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level3CartControllerold : MonoBehaviour
{
   
    [SerializeField] bool trigger;
    private float speed = 0.1f;
    private float xAxisSpeed = 0.017f;

    private float waitingSpeed = 0.03f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Vector3 positions = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        int position = 7;

        if(trigger == true) {           
            transform.position = transform.position + new Vector3(xAxisSpeed * Time.deltaTime,0,-speed * Time.deltaTime);
            position += 1;
        }    
        
        if(trigger != true) {
           
           


        }
    }
}
