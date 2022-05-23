using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshUI : MonoBehaviour
{
    public void SetForceAll()
    {
        GameObject[] boxes = GameObject.FindGameObjectsWithTag("SelectableObj"); // SelectableObj라는 태그를 가진 오브젝트를 다 찾아 배열에 넣음 
        for (int i = 0; i < boxes.Length; i++)
        {
            // box들에 전부 랜덤하게 힘 추가 
            float power = Random.Range(500.0f, 1000.0f);
            Vector3 dir = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            dir = dir.normalized;
            boxes[i].GetComponent<Rigidbody>().AddForce(dir * power);
        }

    }
}

