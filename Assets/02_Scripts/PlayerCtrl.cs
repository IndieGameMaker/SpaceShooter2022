using System.Collections;
using System.Collections.Generic;
using UnityEngine; // 네임스페이스 (클래스의 집합)

public class PlayerCtrl : MonoBehaviour
{
    // 변수 선언
    // 접근제한자(접근한정자) public , private
    private float h = 0.0f;
    private float v = 0.0f;

    // 주석 처리
    // 가장 먼저 호출(실행)되는 함수
    void Start()
    {
        print(h);
    }

    // Update is called once per frame 60, 30 fps
    // Update 함수 : 화면을 렌더링 하는 주기
    // 소스코드의 최적화에 주의
    void Update()
    {
        //h = h + 0.01f;
        h += 0.01f;

        //v = v + 0.02f;
        v += 0.02f;

        //h = h - 0.1f;
        //h -= 0.1f;

        print("h=" + h); // "문자열" + 숫자 => "문자열" + "문자" => "문자열문자"
        print("v=" + v);
    }
}

