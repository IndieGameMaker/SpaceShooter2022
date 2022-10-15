using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterCtrl : MonoBehaviour
{
    // 열거형 변수 (Enumerator) 정의
    public enum MonsterState
    {
        IDLE, TRACE, ATTACK
    }

    // 몬스터의 상태 변수
    public MonsterState state = MonsterState.IDLE;

    // 추적 사정거리
    [Range(5.0f, 20.0f)]
    public float traceDist = 10.0f;

    // 공격 사정거리
    [Range(1.0f, 3.0f)]
    public float attackDist = 2.0f;

    public Transform monsterTr;
    public Transform playerTr;

    // Start is called before the first frame update
    void Start()
    {
        monsterTr = GetComponent<Transform>();

        // Player 태그로 설정된 게임오브젝트를 추출
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");

        // Transform 컴포넌트를 추출
        if (playerObj != null)
        {
            playerTr = playerObj.GetComponent<Transform>();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
