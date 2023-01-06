using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class loadScene : MonoBehaviour
{
    public int ctr=4;
    public int SceneNumber=2;
    public throwcounter script1;
    //public throwcounter2 script2;
    //public throwcounter3 script3;
    //public throwcounter4 script4;

    private float speed = 0.35f;
    private float waitingSpeed = 0.03f;

    void Start()
    {
        Vector3 positions = transform.position;
    }

    void Update()
    {   
        int position = 7;

        if(ctr == 0) {           
            transform.position = transform.position + new Vector3( 0,0,speed * Time.deltaTime);
            position += 1;
        }    
        
        if (ctr==0){
        StartCoroutine(sceneLoader());
        }
    }

    IEnumerator sceneLoader()
    { 
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene(2);
    }

    // void OnTriggerEnter(Collider other)
    //  {
    //      ctr--;
    //      if(ctr<0){
    //         ctr=0;
    //      }
    //  }
    private bool triggerCube1 = false;
    private bool triggerCube2 = false;
    private bool triggerCube3 = false;
    private bool triggerCube4 = false;
     void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Cube") {
            if(triggerCube1 == false) {
                ctr--;
                if(ctr<0 || ctr == 0){
                    ctr=0;
                    Debug.Log("level1   "+ script1.gscore);
                    Debug.Log("level1   "+ script1.gthrowcount);
                }
            }
           triggerCube1 = true;
        }

        if(other.gameObject.name == "Cube (1)") {
            if(triggerCube2 == false) {
                ctr--;
                if(ctr<0 || ctr == 0){
                    ctr=0;
                    Debug.Log("level1   "+ script1.gscore);
                    Debug.Log("level1   "+ script1.gthrowcount);
                }
            }
           triggerCube2 = true;
        }

        if(other.gameObject.name == "Cube (2)") {
            if(triggerCube3 == false) {
                ctr--;
                if(ctr<0 || ctr == 0){
                    ctr=0;
                    Debug.Log("level1   "+ script1.gscore);
                    Debug.Log("level1   "+ script1.gthrowcount);
                }
            }
           triggerCube3 = true;
        }

        if(other.gameObject.name == "Cube (3)") {
            if(triggerCube4 == false) {
               //other.transform.parent = transform;
                ctr--;
                if(ctr<0 || ctr == 0){
                    ctr=0;
                     Debug.Log("level1    "+ script1.gscore);
                    Debug.Log("level1    "+ script1.gthrowcount);
                }
            }
           triggerCube4 = true;
        }

    }
}
