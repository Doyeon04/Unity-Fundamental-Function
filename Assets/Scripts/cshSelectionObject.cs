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
            
           
            }
        }

    }
}

