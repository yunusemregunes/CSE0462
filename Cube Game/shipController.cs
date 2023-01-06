using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipController : MonoBehaviour
{
    public loadScene script;
    GameObject obj;
    [SerializeField] bool trigger;
    private float speed = 0.1f;
    private float waitingSpeed = 0.03f;
    
    
    // Start is called before the first frame update
    void Awake() {
        obj = GameObject.FindGameObjectWithTag("inBasket");
    }

    void Start() {
        Vector3 positions = transform.position;
    }

    IEnumerator wait() {
        int position = 7; 
        yield return new WaitForSeconds(5);        
        transform.position = transform.position + new Vector3(speed * Time.deltaTime , 0, 0);
        position += 1;  
    }

    // Update is called once per frame
    void Update() {
        if (obj.GetComponent<loadScene>().ctr == 0) {
            StartCoroutine(wait());
        }
    }
}
