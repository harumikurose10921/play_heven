using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour {
    GameObject player;
    GameObject enemy;
    Player plyer;
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
	void Start() {
        player = GameObject.Find("overlord");
        enemy = GameObject.Find("DungeonSkeleton_demo");
    }
	
	// Update is called once per frame
	void Update () {
        if (player)
        {
            float dist = Vector3.Distance(transform.localPosition, player.transform.localPosition);
            Vector3 pos = transform.localPosition;
            if (dist > epos)
            {
                pos.x -= move;
            }

            else if (dist < epos)
            {
                SetTrigger("isattack");
            }

            transform.localPosition = pos;
            if (Input.GetKey(KeyCode.Space))
            {
                Instantiate(enemy, transform.localPosition, transform.rotation);
            }
        }

    }
    void OnEmitCollision(Collider colider)
    {
        //Instantiate(enemy, transform.localPosition, transform.rotation);
        Debug.Log("OnEmitAttackCollision");
        BoxCollider boxcolider = gameObject.AddComponent<BoxCollider>();
        boxcolider.isTrigger = true;
        boxcolider.center = new Vector3(0.0f, 1.5f, 0.5f);
        boxcolider.size = new Vector3(2.0f, 1.0f, 1f);
       

        
               
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("result");
            
        }
    }
}
