using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    GameObject player;
    public float move=0.5f;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("overlord");
	}
	
	// Update is called once per frame
	void Update () {
        float dist = Vector3.Distance(transform.localPosition, player.transform.localPosition);
        Vector3 pos = transform.localPosition;
        pos.x -= move;
        transform.localPosition = pos;
        if (dist < 0.5f)
        {
            GameObject.Destroy(gameObject);
        }
        //CharacterController ctr = GetComponent<CharacterController>();
        //Vector3 move = new Vector3();
        //move.x -= 0.05f;
        //ctr.Move(move);
        
	}
}
