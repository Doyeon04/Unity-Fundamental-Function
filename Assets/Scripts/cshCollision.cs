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
            //Destroy(collision.gameObject);

            float power = Random.Range(900.0f, 1300.0f); // ������Ʈ�� ������ ���� �� 
            Vector3 dir = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f)); // ���� (x,y,z) ���� 
            dir = dir.normalized; // ���⸸ ���ϰ� ���� �� �־��� ������ ���̸� 1�� 
            collision.gameObject.GetComponent<Rigidbody>().AddForce(dir * power); // ������Ʈ�� ������ �ִ� rigidbody �Ӽ��� ���� �� �Ӽ��� ��(���� * ���� ��)�� �߰� 


        }
    }
    /*private void OnTriggerEnter(Collider other) // �� ��ü �� �ϳ��� Ʈ���� �����Ǿ� ���� �� �浹 �˻� 
                                                // ��ü ���̿� �浹 �˻�� �ʿ������� �浹 ���Ŀ� ������ ������ �ʿ� ������ 
    {
        if (other.gameObject.tag == "SelectableObj")
        {
            Destroy(other.gameObject);
        }
    }*/

}
