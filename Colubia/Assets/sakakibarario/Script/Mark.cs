using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mark : MonoBehaviour
{
    GameObject player;

    public GameObject Exclamation_mark;
    public GameObject Question_mark;

    //カウント用
    float count =1.0f;

    //bool QM = false;
    bool EM = false;
    bool QM = false;

    // Start is called before the first frame update
    void Start()
    {
        Exclamation_mark.SetActive(false);
        Question_mark.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Player　のゲームオブジェクトを得る
        player = GameObject.FindGameObjectWithTag("Player");
        if (transform.position.x < player.transform.position.x)
        {
            Question_mark.transform.localScale = new Vector2(-1, 1);//左向き
        }
        else if (transform.position.x > player.transform.position.x)
        {
            Question_mark.transform.localScale = new Vector2(1, 1);//左向き
        }


        if (Enemy_Strength_Security_Guard.isActive)
        {
            //EM = true;
            Exclamation_mark.SetActive(true);
            Debug.Log("吃驚マーク");
        }
        else
        {
            Exclamation_mark.SetActive(false);
        }
        if(Enemy_Strength_Security_Guard.EMove_Stop_mark)
        {
             Question_mark.SetActive(true);
            
        }
        else
        {
            Question_mark.SetActive(false);
        }
    }
    private void FixedUpdate()
    {

        


    }
}
