using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class hit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnTriggerEnter(Collider collision)
    {
        //Animator animator = GetComponent<Animator>();
        //animator.speed = -1.0f;
        if (collision.gameObject.tag == "enemy")
        {
            SceneManager.LoadScene("result");
        }
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("title");
        }
        //for(int i = 0; i < 2; i++)
        //{
        //    //クリア条件にする
        //    Destroy(gameObject);
        //}
       
    }

    
}
