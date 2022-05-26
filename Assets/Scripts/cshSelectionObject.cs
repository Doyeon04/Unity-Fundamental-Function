using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshSelectionObject : MonoBehaviour
{
    public Camera cam;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 마우스 왼쪽 버튼을 누르는 순간 한번 
        {
            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            // Input.mousePosition: 내가 클릭한 2차원 마우스 좌표 
            // 로부터 3차원 광선을 만듬 
            if (Physics.Raycast(ray, out hit, Mathf.Infinity)) // 이 광선과 누군가가 만나는지 계산 
                // ray를 무한대까지 쏨 
                // 만난 object가 hit에 들어감
            {
                if (hit.transform.gameObject.tag == "SelectableObj")
                    Debug.Log(hit.transform.gameObject); // 충돌된 게임 오브젝트의 이름을 출력 
                SetForce(hit.transform.gameObject);



            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("마우스 오른쪽 버튼 클릭");
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
        float power = Random.Range(500.0f, 1000.0f); // 오브젝트에 적용할 힘의 양 
        Vector3 dir = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f)); // 방향 (x,y,z) 지정 
        dir = dir.normalized; // 방향만 구하고 싶을 때 주어진 벡터의 길이를 1로 
        obj.GetComponent<Rigidbody>().AddForce(dir * power); // 오브젝트가 가지고 있는 rigidbody 속성을 얻어와 그 속성에 힘(방향 * 힘의 양)을 추가 

    }

    void SetJump(GameObject obj)
    {
        obj.GetComponent<Rigidbody>().AddForce(Vector3.up * 6.0f, ForceMode.Impulse);
    }



}

