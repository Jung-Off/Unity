using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidbody; // 이동에 사용할 리지드바디 컴포넌ㅌ
    public float speed = 8f; //이동 속력

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        { 
            playerRigidbody.AddForce(0f, 0f, speed);
            //위쪽 방향키 입력이 감지된 경우 Z방향 힘주기
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerRigidbody.AddForce(0f, 0f, -speed);
            //아래 방향키 입력이 감지된 경우 -Z방향 힘주기
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRigidbody.AddForce(speed, 0f, 0f);
            //오른쪽 방향키 입력이 감지된 경우 x방향 힘주기
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRigidbody.AddForce(-speed, 0f, 0f);
            //왼쪽 방향키 입력이 감지된 경우 -x방향 힘주기
        }
    }

    public void Die()
    {
        //자신의 게임 오브젝트를 비활성화
        gameObject.SetActive(false);
    }
}
