using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Enemylife : MonoBehaviour {

    public readonly float maxLife = 10;  //最大体力
    public float life = 10;              //現在体力
	// Use this for initialization
	void Start () {
        life = maxLife;//体力全回復
	}
	
	// Update is called once per frame
	void Update () {
        if (life <= 0)
        {
            Dead();
        }
	}
    public void Damage(float damage)
    {
      //life -= damage;　//体力を減らす
    }
    //死亡処理
    public void Dead()
    {
        GameClear();//ゲームクリアー
    }
    //ゲームクリアー処理
    public void GameClear()
    {
        SceneManager.LoadScene("result");
    }
}
