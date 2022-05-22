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
        float h = Input.GetAxis("Horizontal"); // �¿� (���� Ű ������ -1, ������ Ű ������ +1)
        float v = Input.GetAxis("Vertical"); // ���Ʒ� (�Ʒ� Ű ������ -1, �� Ű ������ +1)

        Vector3 moveHorizontal = Vector3.right * h; // + or - (1,0,0)
        Vector3 moveVertical = Vector3.forward * v; // + or - (0,0,1)
        Vector3 velocity = (moveHorizontal + moveVertical).normalized; // normalized : �־��� ������ ���̸� 1�� ���� 
        // ���� ĳ���Ͱ� �̵��ϴ� ���⸸ ����ϱ� ���� 

        transform.LookAt(transform.position + velocity); // ���� ĳ���Ͱ� �̵��Ϸ��� �ϴ� �������� �Ĵٺ� 

        transform.Translate(velocity * m_moveSpeed * Time.deltaTime, Space.World); 
        // �̵��Ϸ��� �ϴ� ���� * ������ ũ�� * Time.deltaTime, world�� �������� ��ǥ ����
        // pc ����� �������� delta time�� �۾�����. 
    }
}
