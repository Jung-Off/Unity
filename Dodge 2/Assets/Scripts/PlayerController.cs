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
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);

        playerRigidbody.velocity = newVelocity;
    }

    public void Die()
    {
        //자신의 게임 오브젝트를 비활성화
        gameObject.SetActive(false);

        //씬에 존재하는 GameManager 타입의 오브젝트를 찾아서 가져오기

        GameManager gameManager = FindObjectOfType<GameManager>();
        //가져온 GameManager 오브젝트의 EndGame() 메서드 실행
        gameManager.EndGame();
    }
}
