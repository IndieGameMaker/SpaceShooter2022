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

    void Start()
    {

    }

    void Update()
    {
        // GetAxis 함수 / 메소드 (명령, 동사) , 대문자 시작, 파스칼 표기법 GetAge, GetLevel, SetItem
        h = Input.GetAxis("Horizontal"); // -1.0f ~ 0.0f ~ +1.0f
        Debug.Log("h=" + h);
        v = Input.GetAxis("Vertical"); // -1.0f ~ 0.0f ~ +1.0f
        Debug.Log("v=" + v);
    }
}




/*
https://drive.google.com/drive/folders/1ON_4LXOJmg9zYtnaSiasGuCuBGmquuzO?usp=sharing
*/