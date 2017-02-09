using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EnemyHit : MonoBehaviour {
    public float attack = 10f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider colider)
    {
        if (colider.gameObject.tag == "Player")
        {
            Attack(colider.gameObject);
        }
    }

    public void Attack(GameObject hit)
    {
        hit.gameObject.SendMessage("Damage", attack);
    }
}
