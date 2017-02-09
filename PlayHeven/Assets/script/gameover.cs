using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class gameover : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A) == true)
        {
            SceneManager.LoadScene("result");
        }
    }
}
