using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshAnimation : MonoBehaviour
{
    private Animator ani; // Animator 저장 변수 
    private float speed = 0.0f;
    void Start()
    {
        ani = GetComponent<Animator>(); // 현재 캐릭터가 가지고 있는 animator 속성 받아옴 
    }

    void Update()
    {
        if (Input.GetMouseButton(0)) // 마우스 왼쪽 버튼이 눌리고 있으면 
        {
            speed += 0.01f; // speed 값이 0.01씩 증가 
            if (speed > 1.0f) speed = 1.0f; // 1보다 커지면 1로 고정 
        }
        else if (Input.GetMouseButtonUp(0)) // 마우스 왼쪽 버튼을 떼면 
        {
            speed = 0.0f; // speed를 0으로 초기화 
        }
        else if (Input.GetMouseButtonDown(1)) // 마우스 오른쪽 버튼을 누르면 
        {
            ani.SetBool("isWave", true); 
        }
        else if (Input.GetMouseButtonUp(1)) // 마우스 오른쪽 버튼을 떼면 
        {
            ani.SetBool("isWave", false);
        }
        ani.SetFloat("Speed", speed); // speed값을 내가 설정한 speed값으로
    }
}

