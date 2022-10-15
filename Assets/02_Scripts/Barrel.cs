using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    public GameObject expEffect;
    // 텍스처를 저장하기 위한 배열(Array) 선언
    public Texture[] textures;

    // 차일드에 있는 MeshRenderer 컴포넌트를 저장할 변수를 선언
    [HideInInspector]
    public new MeshRenderer renderer;

    private int hitCount = 0;

    void Start()
    {
        renderer = GetComponentInChildren<MeshRenderer>();
    }

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
                Destroy(obj, 4.0f);

                // 위로 올라가는 로직
                var rb = this.gameObject.AddComponent<Rigidbody>();
                rb.AddForce(Vector3.up * 1500.0f);

                Destroy(this.gameObject, 2.0f);
            }
        }
    }
}
