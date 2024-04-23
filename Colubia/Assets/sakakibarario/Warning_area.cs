using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warning_area : MonoBehaviour
{
    private bool inarea = false;
    public float count_area = 1.5f;

    private void Start()
    {
        
    }
    private void Update()
    {
        if (!inarea)
        {
            count_area = 1.5f;//�G���A�^�C���̃��Z�b�g
            gameObject.GetComponent<SpriteRenderer>().color = new Color32(248, 255, 93, 130);//�F�̃��Z�b�g
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")// ��l��
        {
         �@  inarea = true;
         �@    count_area -= Time.deltaTime;//�J�E���g
         �@if (count_area < 0.5)
         �@{
         �@     gameObject.GetComponent<SpriteRenderer>().color = new Color32(255, 0, 0, 130);//�F��ύX�i�ԁj
         �@}
         �@if(count_area <0)
         �@{
                // �Q�[���I�[�o�[�������Ă�
                FindObjectOfType<GameManager>().dispatch(GameManager.GameState.Over);
            }
        }
        else
        {
            inarea = false;
        }
    }
}