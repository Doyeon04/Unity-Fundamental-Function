using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshPlayerController : MonoBehaviour
{
    public float m_moveSpeed = 2.0f;

    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        float h = Input.GetAxis("Horizontal"); // 좌우 (왼쪽 키 누르면 -1, 오른쪽 키 누르면 +1)
        float v = Input.GetAxis("Vertical"); // 위아래 (아래 키 누르면 -1, 위 키 누르면 +1)

        Vector3 moveHorizontal = Vector3.right * h; // + or - (1,0,0)
        Vector3 moveVertical = Vector3.forward * v; // + or - (0,0,1)
        Vector3 velocity = (moveHorizontal + moveVertical).normalized; // normalized : 주어진 벡터의 길이를 1로 만듬 
        // 현재 캐릭터가 이동하는 방향만 계산하기 위함 

        transform.LookAt(transform.position + velocity); // 현재 캐릭터가 이동하려고 하는 방향으로 쳐다봄 

        transform.Translate(velocity * m_moveSpeed * Time.deltaTime, Space.World); 
        // 이동하려고 하는 방향 * 벡터의 크기 * Time.deltaTime, world축 기준으로 좌표 설정
        // pc 사양이 좋을수록 delta time은 작아진다. 
    }
}
