using UnityEngine;

public class RemoveBullet : MonoBehaviour
{
    public GameObject sparkEffect;

    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.CompareTag("BULLET"))
        {
            // 총알을 삭제
            Destroy(coll.gameObject);

            // 스파크 효과 생성
            // 충돌 정보를 추출
            ContactPoint cp = coll.GetContact(0);

            // 충돌 좌푯값 추출
            Vector3 pos = cp.point;

            // 충돌 지점의 법선벡터(수직 벡터) 추출
            Vector3 _normal = -cp.normal;

            // 유니티 엔진내부에서 사용하는 각도의 단위인 쿼터니언 타입으로 변화
            Quaternion rot = Quaternion.LookRotation(_normal);

            // 스파크를 생성 Instanciate(객체, 위치, 각도)
            Instantiate(sparkEffect, pos, rot);
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

