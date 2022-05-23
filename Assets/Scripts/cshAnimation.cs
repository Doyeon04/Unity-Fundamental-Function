using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshAnimation : MonoBehaviour
{
    private Animator ani; // Animator ���� ���� 
    private float speed = 0.0f;
    void Start()
    {
        ani = GetComponent<Animator>(); // ���� ĳ���Ͱ� ������ �ִ� animator �Ӽ� �޾ƿ� 
    }

    void Update()
    {
        if (Input.GetMouseButton(0)) // ���콺 ���� ��ư�� ������ ������ 
        {
            speed += 0.01f; // speed ���� 0.01�� ���� 
            if (speed > 1.0f) speed = 1.0f; // 1���� Ŀ���� 1�� ���� 
        }
        else if (Input.GetMouseButtonUp(0)) // ���콺 ���� ��ư�� ���� 
        {
            speed = 0.0f; // speed�� 0���� �ʱ�ȭ 
        }
        else if (Input.GetMouseButtonDown(1)) // ���콺 ������ ��ư�� ������ 
        {
            ani.SetBool("isWave", true); 
        }
        else if (Input.GetMouseButtonUp(1)) // ���콺 ������ ��ư�� ���� 
        {
            ani.SetBool("isWave", false);
        }
        ani.SetFloat("Speed", speed); // speed���� ���� ������ speed������
    }
}

