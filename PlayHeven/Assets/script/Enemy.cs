using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    GameObject player;
    public float move=0.05f;
    public float epos = 1.0f;
    IEnumerator _SetTrigger(string name)
    {
        Animator animator = GetComponent<Animator>();
        animator.SetBool(name, true);
        yield return new WaitForSeconds(0);
        animator.SetBool(name, false);
    }
    /// <summary>
    /// フラグのトリガー設定。
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    void SetTrigger(string name)
    {
        StartCoroutine(_SetTrigger(name));
    }
	// Use this for initialization
	void Start () {
        player = GameObject.Find("overlord");
	}
	
	// Update is called once per frame
	void Update () {
        float dist = Vector3.Distance(transform.localPosition, player.transform.localPosition);
        Vector3 pos = transform.localPosition;
        if (dist > epos)
        {
            pos.x -= move;
        }
        else if (dist < epos)
        {
            
            SetTrigger("isattack");
            //GameObject.Destroy(gameObject);
        }
        transform.localPosition = pos;
	}
   
}
