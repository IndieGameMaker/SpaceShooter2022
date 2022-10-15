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

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
