using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    // 그냥 변수이름 변수이름이라 소문자로 쓴거임 
    GameObject player;
    void Start()
    {
        // 유니티에 있는 Hierarchy에 있는 명이랑 똑같아야함
        player = GameObject.Find("player");

    }

    // Update is called once per frame
    void Update()
    {
        // 가로안에는 float타입만 받기 때문에 f를 표시해야 좋음
        // 정수를 입력하면 더블로 알아먹음

        // 밑으로 내려감
        transform.Translate(0.0f, -0.1f, 0.0f);

        if( transform.position.y < -5.0f){
            // GameObject 는 타입임
            // gameObject는 arrow 변수임
            Destroy(gameObject);
        }

        //충돌 확인

        // 포지션 xyz값 가져옴
        // p1 : arrow 값
        // p2 : player 값
        Vector2 p1 = transform.position;  // 화살의 중심 좌표
        Vector2 p2 = player.transform.position; // 플레이어 중심 좌표
        Vector2 dir = p1-p2; 

        float d = dir.magnitude;
        float r1 = 0.5f;  // 화살의 반지름 
        float r2 = 1.0f;  // 플레이어의 반지름

        if(d < r1+r2){

            // 감독 스크립트에 플레이어와 화살이 충돌했다고 전달함

            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHP();
            
            // 두개가 충돌했을때 삭제 
            Destroy(gameObject);
            Debug.Log("화살표가 충돌했슴다!!!!");
        }

    }
}
