using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level3Controller : MonoBehaviour
{

    public int ctr = 4;
    public bucketCounter script1;
    public level3CartController script;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ctr == 0){
            StartCoroutine(sceneLoader());
        }
    }

    IEnumerator sceneLoader()
    {
        yield return new WaitForSeconds(10);
        Debug.Log("level3    "+ script1.gscore);
        Debug.Log("level3    "+ script1.gthrowcount);
        SceneManager.LoadScene(4);
    }

    private bool triggerBasket1 = false;
    private bool triggerBasket2 = false;
    private bool triggerBasket3 = false;
    private bool triggerBasket4 = false;

    void OnTriggerEnter(Collider other)
     {
        if(other.gameObject.name == "Wooden_Bucket") {
            if(triggerBasket1 == false) {
               // Debug.Log("1"+ctr);
                ctr--;
                if(ctr<0 || ctr == 0){
                    ctr=0;
                    script.trigger = true;
                    
                }
            }
           triggerBasket1 = true;
        }

        if(other.gameObject.name == "Wooden_Bucket (1)") {
            if(triggerBasket2 == false) {
                //Debug.Log("2"+ctr);
                ctr--;
                if(ctr<0 || ctr == 0){
                    ctr=0;
                    script.trigger = true;
                    
                }
            }
           triggerBasket2 = true;
        }
        
        if(other.gameObject.name == "Wooden_Bucket (2)") {
            if(triggerBasket3 == false) {
                //Debug.Log("3"+ctr);
                ctr--;
                if(ctr<0 || ctr == 0){
                    ctr=0;
                    script.trigger = true;
                    
                }
            }
           triggerBasket3 = true;
        }
        if(other.gameObject.name == "Wooden_Bucket (3)") {
            if(triggerBasket4 == false) {
                //Debug.Log("3"+ctr);
                ctr--;
                if(ctr<0 || ctr == 0){
                    ctr=0;
                    script.trigger = true;
         
                }
            }
           triggerBasket4 = true;
        }
    }
}
