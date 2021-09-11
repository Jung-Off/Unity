using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody bulletRigidbody;

    void Start()
    {
        //게임 오브젝트에서 rigidbody 컴포넌트를 찾아 bulletrigidbody에 할다
        bulletRigidbody = GetComponent<Rigidbody>();

        //리지드바디의 속도 = 앞쪽 * 이동 속력
        bulletRigidbody.velocity = transform.forward * speed;

        Destroy(gameObject, 3f);
    }

    //트리거 충돌시 자동으로 실행되는 메서드
    void OnTriggerEnter(Collider other)
    {
        // 충돌한 상대방 게임 오브젝트가 player 태그를 가진 경우
        if (other.tag == "Player")
        {
            //상대방 게임 오브젝트에서 playercontroller 컴포넌트 가져오기
            PlayerController playerController = other.GetComponent<PlayerController>();

            //상대방으로부터 pllayercontroller 컴포넌트를 가져오는데 성공했다면
            if(playerController != null)
            {
                // 상대방 playercontroller 컴포넌트의 die()메서드 실행
                playerController.Die();
            }
        }
    }
}