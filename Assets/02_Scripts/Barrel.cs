using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Barrel : MonoBehaviour
{
    public GameObject expEffect;
    // 텍스처를 저장하기 위한 배열(Array) 선언
    public Texture[] textures;
    public AudioClip expSfx;

    // 차일드에 있는 MeshRenderer 컴포넌트를 저장할 변수를 선언
    [HideInInspector]
    public new MeshRenderer renderer;

    private int hitCount = 0;

    void Start()
    {
        renderer = GetComponentInChildren<MeshRenderer>();

        /*  Random.Range의 난수 발생범위
            Random.Range(0, 10); 정수일 경우 => 0, 1, 2, ..., 9
            Random.Range(0.0f, 10.0f); 실수 => 0.0f, .... , 10.0f
        */

        int index = Random.Range(0, textures.Length); //0, 1, 2

        // 텍스처 교체
        renderer.material.mainTexture = textures[index];
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
