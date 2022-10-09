using System.Collections;
using System.Collections.Generic;
using UnityEngine; // 네임스페이스 (클래스의 집합)

public class PlayerCtrl : MonoBehaviour
{
    // 변수 선언
    // 접근제한자(접근한정자) public , private
    private float h = 0.0f;
    private float v = 0.0f;

    // Transform 컴포넌트를 저장하기 위한 변수 선언
    public Transform tr;
    public float moveSpeed = 8.0f;

    void Start()
    {

    }

    void Update()
    {
        // GetAxis 함수 / 메소드 (명령, 동사) , 대문자 시작, 파스칼 표기법 GetAge, GetLevel, SetItem
        h = Input.GetAxis("Horizontal"); // -1.0f ~ 0.0f ~ +1.0f
        v = Input.GetAxis("Vertical"); // -1.0f ~ 0.0f ~ +1.0f

        // 벡터의 덧셈 연산을 통해서 방향을 계산
        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);
        tr.Translate(moveDir.normalized * Time.deltaTime * moveSpeed);
    }
}


/* Shothand
    Vector3.forward = Vector3(0, 0, 1)
    Vector3.up      = Vector3(0, 1, 0)
    Vector3.right   = Vector3(1, 0, 0)

    Vector3.one = Vector3(1, 1, 1)
    Vector3.zero = Vector3(0, 0, 0)


벡터 Vector : 방향, 크기

구조체(클래스와 유사)
Vector3 (x, y, z)

변수 선언

Vector3 direction = new Vector3(3, 2, 1);

direction.x = 3;
direction.y = 2;
direction.z = 1;


100, 200 : 스칼라

*/



/*
https://drive.google.com/drive/folders/1ON_4LXOJmg9zYtnaSiasGuCuBGmquuzO?usp=sharing
*/