using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // 로컬좌표계 기준으로 힘을 가하는 메소드(함수)
        rb.AddRelativeForce(Vector3.forward * 1000.0f);
    }

}
