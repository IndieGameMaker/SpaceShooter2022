using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;   // 네비게이션 관련 컴포넌트를 사용하기 위해서 정의

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

    public NavMeshAgent agent;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        monsterTr = GetComponent<Transform>();

        // Player 태그로 설정된 게임오브젝트를 추출
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");

        // Transform 컴포넌트를 추출
        if (playerObj != null)
        {
            playerTr = playerObj.GetComponent<Transform>();
        }
    }

    void Update()
    {
        CheckMonsterState();
        MonsterAction();
    }

    void CheckMonsterState()
    {
        // 몬스터와 주인공 간의 거리를 계산
        // Vector3.Distance(A, B) 

        float distance = Vector3.Distance(monsterTr.position, playerTr.position);

        if (distance <= attackDist)     //공격 사정거리 이내일 경우
        {
            state = MonsterState.ATTACK;
        }
        else if (distance <= traceDist) //추적 사정거리 이내일 경우
        {
            state = MonsterState.TRACE;
        }
        else
        {
            state = MonsterState.IDLE;
        }
    }

    void MonsterAction()
    {
        switch (state)
        {
            case MonsterState.IDLE:
                // 로직 
                agent.isStopped = true;
                break;

            case MonsterState.TRACE:
                // 추적로직
                agent.SetDestination(playerTr.position);
                agent.isStopped = false;
                break;

            case MonsterState.ATTACK:
                // 공격로직
                break;
        }
    }
}
