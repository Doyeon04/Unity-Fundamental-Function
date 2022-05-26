using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshSelectionObject : MonoBehaviour
{
    public Camera cam;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // ���콺 ���� ��ư�� ������ ���� �ѹ� 
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            // Input.mousePosition: ���� Ŭ���� 2���� ���콺 ��ǥ 
            // �κ��� 3���� ������ ���� 
            if (Physics.Raycast(ray, out hit, Mathf.Infinity)) // �� ������ �������� �������� ��� 
                // ray�� ���Ѵ���� �� 
                // ���� object�� hit�� ��
            {
                if (hit.transform.gameObject.tag == "SelectableObj")
                    Debug.Log(hit.transform.gameObject); // �浹�� ���� ������Ʈ�� �̸��� ��� 
                SetForce(hit.transform.gameObject);



            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("���콺 ������ ��ư Ŭ��");
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                if (hit.transform.gameObject.tag == "SelectableObj")
                {
                    SetJump(hit.transform.gameObject);
                }
                   
               
            }

        }

    }

    void SetForce(GameObject obj)
    {
        float power = Random.Range(500.0f, 1000.0f); // ������Ʈ�� ������ ���� �� 
        Vector3 dir = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f)); // ���� (x,y,z) ���� 
        dir = dir.normalized; // ���⸸ ���ϰ� ���� �� �־��� ������ ���̸� 1�� 
        obj.GetComponent<Rigidbody>().AddForce(dir * power); // ������Ʈ�� ������ �ִ� rigidbody �Ӽ��� ���� �� �Ӽ��� ��(���� * ���� ��)�� �߰� 

    }

    void SetJump(GameObject obj)
    {
        obj.GetComponent<Rigidbody>().AddForce(Vector3.up * 6.0f, ForceMode.Impulse);
    }



}

