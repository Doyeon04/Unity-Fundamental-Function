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
            
           
            }
        }

    }
}

