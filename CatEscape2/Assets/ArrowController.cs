using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
public class ArrowController : MonoBehaviour
{
    GameObject player;

    void Start()
    {
        player = GameObject.Find("player_0");
    }

    void Update()
    {
        // 프레임마다 0.1씩 내려가는거임 
        // 프레임 == 60 임 
        transform.Translate(0,-0.1f,0);

        // 프레임 밖으로 나가면 arrow 삭제하기 
        if(transform.position.y < -5){
            Destroy(gameObject);
        }


        // 충돌 방지 
        
        Vector2 arrow_p = transform.position;
        Vector2 player_p = player.transform.position;

        Vector2 dir = arrow_p-player_p;

        float d = dir.magnitude;

        float arrow_r = 0.5f;
        float player_r = 1.0f;

        if(d< arrow_r + player_r){
            // 충돌시 화살을 지운다
            Destroy(gameObject);

            // 게임감독 오브젝트 가져오기
            GameObject gamedirector = GameObject.Find("GameDirector");

            // 게임감독에서 함수 가져와서 실행하기
            gamedirector.GetComponent<GameDirector>().hpGauge_m();


        }
    }
}
