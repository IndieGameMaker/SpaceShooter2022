using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    // 총알 프리팹을 저장할 변수
    public GameObject bulletPrefab;
    // 총알을 생성할 위치
    public Transform firePos;

    // 음원파일 - 총소리 음원
    public AudioClip fireSfx;
    // AudioSource 컴포넌트를 저장할 변수
    public new AudioSource audio;

    void Update()
    {
        // 마우스 왼쪽 버튼을 클릭할 때
        if (Input.GetMouseButtonDown(0) == true)
        {
            FireBullet(); // 함수명(파라메터1, 파라메터1,...)  함수명()
        }
    }

    // 총알 생성(발사)/ 총소리 발생
    void FireBullet()
    {
        // 총알 프리팹을 생성
        Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        // 총소리 발생
        audio.PlayOneShot(fireSfx, 0.8f);
    }
}

/*
        // 왼쪽 마우스 버튼을 클릭할 때
        if (조건 == 참)
        {
            // 조건이 참(true)일 경우 실행하는 부분
        }
        else
        {
            // 조건이 거짓(false)일 경우 실행하는 부분
        }

*/


/*
    Sound 처리

    AudioMixer

    AudioListener -- 반드시 1개만 존재

    AudioSource  -- 소리를 발생시키는 컴포넌트



*/