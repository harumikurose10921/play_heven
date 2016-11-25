using UnityEngine;
using System.Collections;

public class hit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnTriggerEnter(Collider collision)
    {
        Animator animator = GetComponent<Animator>();
        animator.speed = -1.0f;
        //Destroy(gameObject);
    }
}
