using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameManager gameManager;

    void Start()
    {
        //�Q�[���I�u�W�F�N�g��T���ĕϐ��ɍT���Ă���
        GameObject managerObject = GameObject.Find("GameManager");

        //�T���Ă������Q�[���I�u�W�F�N�g�ɑ΂���GetComponent��GameManager�R���|�[�l���g���擾
        gameManager = managerObject.GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player") //other.tag �ł��\
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
