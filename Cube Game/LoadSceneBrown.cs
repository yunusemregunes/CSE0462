using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class LoadSceneBrown : MonoBehaviour
{
    public LoadSceneWhite secondScript;
    public cube21b script1;
    public manController script;
    public int tempCounter = 3;
    public int SceneNumber=2;
    private float speed = 0.1f;
    private float waitingSpeed = 0.03f;

    void Update()
    {
        int position = 7;
        if(secondScript.ctr == 0) {           
            script.animator.SetInteger("score", 10);
        }    
        
        if (secondScript.ctr==0){
            StartCoroutine(sceneLoader());
        }
        
    }

    IEnumerator sceneLoader()
    {
        //Debug.Log("5");
        yield return new WaitForSeconds(5);
        Debug.Log("level2"+ script1.gscore);
        Debug.Log("level2"+ script1.gthrowcount);
        //Debug.Log("6");
        SceneManager.LoadScene(3);
    }

    private bool triggerLog1 = false;
    private bool triggerLog2 = false;
    private bool triggerLog3 = false;

    void OnTriggerEnter(Collider other)
     {
        if(other.gameObject.name == "Log") {
            if(triggerLog1 == false) {
               // Debug.Log("1"+secondScript.ctr);
                secondScript.ctr--;
                tempCounter--;
                if(secondScript.ctr<0){
                    secondScript.ctr=0;
                }
            }
           triggerLog1 = true;
        }

        if(other.gameObject.name == "Log (1)") {
            if(triggerLog2 == false) {
                //Debug.Log("2"+secondScript.ctr);
                secondScript.ctr--;
                tempCounter--;
                if(secondScript.ctr<0){
                    secondScript.ctr=0;
                }
            }
           triggerLog2 = true;
        }
        
        if(other.gameObject.name == "Log (2)") {
            if(triggerLog3 == false) {
              //  Debug.Log("3"+secondScript.ctr);
                secondScript.ctr--;
                tempCounter--;
                if(secondScript.ctr<0){
                    secondScript.ctr=0;
                }
            }
           triggerLog3 = true;
        }

     }
      void Start()
    {
        Vector3 positions = transform.position;
    }

}