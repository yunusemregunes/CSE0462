using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class LoadSceneWhite : MonoBehaviour
{
    public manController script;
    public int ctr=6;
    public int SceneNumber=2;
    private float speed = 0.1f;
    private float waitingSpeed = 0.03f;

    void Update()
    {
        //  if (ctr==0){
        //  StartCoroutine(sceneLoader());
        //  }
        int position = 7;

        if(ctr == 0) {           
            script.animator.SetInteger("score", 10);
            //StartCoroutine(sceneLoader());
        }    
        
        // if (ctr==0){
        //     StartCoroutine(sceneLoader());
        // }
    }
    void Start()
    {
        Vector3 positions = transform.position;
    }

    // IEnumerator sceneLoader()
    // {
    //     Debug.Log("5");
    //     yield return new WaitForSeconds(10);
    //     Debug.Log("6");
    //     SceneManager.LoadScene(SceneNumber);
    // }

   
        private bool triggerLog4 = false;
        private bool triggerLog5 = false;
        private bool triggerLog6 = false;

    void OnTriggerEnter(Collider other) {
       
        if(other.gameObject.name == "Log (3)") {
            if(triggerLog4 == false) {
               // Debug.Log("4"+ctr);
                ctr--;
                if(ctr<0){
                    ctr=0;
                }
            }
           triggerLog4 = true;
        }

        if(other.gameObject.name == "Log (4)") {
            if(triggerLog5 == false) {
                //Debug.Log("5"+ctr);
                ctr--;
                if(ctr<0){
                    ctr=0;
                }
            }
           triggerLog5 = true;
        }
        
        if(other.gameObject.name == "Log (5)") {
            if(triggerLog6 == false) {
                //Debug.Log("6"+ctr);
                ctr--;
                if(ctr<0){
                    ctr=0;
                }
            }
           triggerLog6 = true;
        }

    }

}