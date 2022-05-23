using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision) // 일반적인 충돌체 사이의 충돌 검사 
        // 충돌과 함께 물리적인 현상 필요하면 
    {
        if (collision.gameObject.tag == "SelectableObj")
        {
            Destroy(collision.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other) // 두 물체 중 하나라도 트리거 설정되어 있을 때 충돌 검사 
        // 물체 사이에 충돌 검사는 필요하지만 충돌 이후에 물리적 반응은 필요 없으면 
    {
        if (other.gameObject.tag == "SelectableObj")
        {
            Destroy(other.gameObject);
        }
    }

}
