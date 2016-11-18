using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
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
	}
}
