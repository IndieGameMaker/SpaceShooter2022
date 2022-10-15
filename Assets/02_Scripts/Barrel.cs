using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    public GameObject expEffect;

    private int hitCount = 0;

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.CompareTag("BULLET"))
        {

            // 전치 증감연산자
            ++hitCount; // hitCount += 1; // hitCount = hitCount + 1;
            if (hitCount == 3)
            {
                // 폭발효과 이펙트
                var obj = Instantiate(expEffect, transform.position, transform.rotation);
                Destroy(obj, 5.0f);

                // 위로 올라가는 로직
                var rb = this.gameObject.AddComponent<Rigidbody>();
                rb.AddForce(Vector3.up * 1500.0f);

                Destroy(this.gameObject, 2.0f);
            }
        }
    }
}
