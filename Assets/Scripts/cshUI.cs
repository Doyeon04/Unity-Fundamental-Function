using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshUI : MonoBehaviour
{
    public void SetForceAll()
    {
        GameObject[] boxes = GameObject.FindGameObjectsWithTag("SelectableObj"); // SelectableObj��� �±׸� ���� ������Ʈ�� �� ã�� �迭�� ���� 
        for (int i = 0; i < boxes.Length; i++)
        {
            // box�鿡 ���� �����ϰ� �� �߰� 
            float power = Random.Range(500.0f, 1000.0f);
            Vector3 dir = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            dir = dir.normalized;
            boxes[i].GetComponent<Rigidbody>().AddForce(dir * power);
        }

    }
}

