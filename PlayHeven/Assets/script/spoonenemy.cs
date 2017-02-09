using UnityEngine;
using System.Collections;

public class spoonenemy : MonoBehaviour {

    [SerializeField]
    GameObject enemy;

    float LT = 0;
	
    // Use this for initialization
	void Start () {
    }

    // Update is called once per frame
    void Update()
    {
        LT += Time.deltaTime;

        if (LT >= 3.0f)
        {
            Instantiate(enemy, new Vector3(6.79f, 0.54f, 0.0f), transform.rotation);

            LT = 0;
        }
    }

}
