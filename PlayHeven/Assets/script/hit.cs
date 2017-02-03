using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class hit : MonoBehaviour {
    GameObject enemy;
    // Use this for initialization
    void Start () {
         enemy = GameObject.Find("DungeonSkeleton_demo");
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnTriggerEnter(Collider collision)
    {
   
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(enemy);
           //SceneManager.LoadScene("result");
        }

        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("title");
        }

     
    }


}
