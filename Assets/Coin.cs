using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameManager gameManager;

    void Start()
    {
        //ゲームオブジェクトを探して変数に控えておく
        GameObject managerObject = GameObject.Find("GameManager");

        //控えておいたゲームオブジェクトに対してGetComponentでGameManagerコンポーネントを取得
        gameManager = managerObject.GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player") //other.tag でも可能
        {
            gameManager.AddCoinCount();
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        
    }
}
