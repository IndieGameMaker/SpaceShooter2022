using UnityEngine;

public class RemoveBullet : MonoBehaviour
{
    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.CompareTag("BULLET"))
        {
            // 총알을 삭제
            Destroy(coll.gameObject);
        }
    }
}

// 충돌 콜백함수 Collision Callback Function
/*
    Collider 컴포넌트의 Is Trigger 언체크

    OnCollisionEnter()  1회 호출
    OnCollisionStay()   n회 호출
    OnCollisionExit()   1회 호출


    Collider 컴포넌트의 Is Trigger 체크

    OnTriggerEnter()  1회 호출
    OnTriggerStay()   n회 호출
    OnTriggerExit()   1회 호출
*/