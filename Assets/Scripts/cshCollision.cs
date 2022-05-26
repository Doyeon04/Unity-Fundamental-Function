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
            //Destroy(collision.gameObject);

            float power = Random.Range(900.0f, 1300.0f); // 오브젝트에 적용할 힘의 양 
            Vector3 dir = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f)); // 방향 (x,y,z) 지정 
            dir = dir.normalized; // 방향만 구하고 싶을 때 주어진 벡터의 길이를 1로 
            collision.gameObject.GetComponent<Rigidbody>().AddForce(dir * power); // 오브젝트가 가지고 있는 rigidbody 속성을 얻어와 그 속성에 힘(방향 * 힘의 양)을 추가 


        }
    }
    /*private void OnTriggerEnter(Collider other) // 두 물체 중 하나라도 트리거 설정되어 있을 때 충돌 검사 
                                                // 물체 사이에 충돌 검사는 필요하지만 충돌 이후에 물리적 반응은 필요 없으면 
    {
        if (other.gameObject.tag == "SelectableObj")
        {
            Destroy(other.gameObject);
        }
    }*/

}
