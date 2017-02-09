using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
    GameObject enemy;
    Enemylife elife;
    public int count = 0;
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
        enemy = GameObject.Find("DungeonSkeleton_demo");
    }
	
	// Update is called once per frame
	void Update () {
        Animator animator = GetComponent<Animator>();
        if (Input.GetKeyDown(KeyCode.A) == true)
        {
            SetTrigger("isattack1L");
        }
        if (Input.GetKeyDown(KeyCode.D) == true)
        {
            SetTrigger("block");
        }
        if (Input.GetMouseButtonDown(0))
        {
            SetTrigger("isattack1L");
        }
        if (Input.GetMouseButtonDown(1))
        {
            SetTrigger("block");
        }
        
	}
    void OnEmitAttackCollision(Collider colision)
    {
        Instantiate(enemy,new Vector3(6.79f,0.54f,0.0f), transform.rotation);
        Debug.Log("OnEmitAttackCollision");
        Destroy(enemy);
        elife.Dead();
    }
   
}
