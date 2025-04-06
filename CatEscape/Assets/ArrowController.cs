using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        // 이름과 똑같은 오브젝트를 찾아서 player 변수에 넣는다
        player = GameObject.Find("player_0");
    }

    void Update()
    {
        // 1. Arrow 떨어트리기
        // 프레임마다 등속으로 낙하시킨다
        transform.Translate(0,-0.01f,0);

        // 화면 밖으로 나오면 "Arrow" 소멸시킨다
        if(transform.position.y < -5.0f){

            // Destroy : 메서드 
            // gameObject : 자신을 가리키는 -> arrow
            Destroy(gameObject); 
        }

        // 2. 충돌 판정
        Vector2 arrow_position = transform.position;
        Vector2 player_position = player.transform.position;

        Vector2 dir = arrow_position - player_position;

        // arrow와 player 중심점 거리값 
        float d = dir.magnitude;

        // arrow의 원의 반지름
        float arrow_r1 = 0.5f;
        // player의 원의 반지름
        float player_r2 = 1.0f;

        if(d < arrow_r1+player_r2){
            // 감독 스크립트에 플레이어와 화살이 충돌전달
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHP();
            
            //충돌할 경우 Arrow를 지운다
            Destroy(gameObject);
        }   
    }
}
