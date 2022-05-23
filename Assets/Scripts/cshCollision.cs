using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision) // �Ϲ����� �浹ü ������ �浹 �˻� 
        // �浹�� �Բ� �������� ���� �ʿ��ϸ� 
    {
        if (collision.gameObject.tag == "SelectableObj")
        {
            Destroy(collision.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other) // �� ��ü �� �ϳ��� Ʈ���� �����Ǿ� ���� �� �浹 �˻� 
        // ��ü ���̿� �浹 �˻�� �ʿ������� �浹 ���Ŀ� ������ ������ �ʿ� ������ 
    {
        if (other.gameObject.tag == "SelectableObj")
        {
            Destroy(other.gameObject);
        }
    }

}
