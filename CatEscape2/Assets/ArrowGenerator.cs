using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    // 반복할 프리맵 부르기
    public GameObject arrowprefeb;

    // 1초마다 생성하겠다는 변수
    float span = 1.0f;

    // 프레임 시간 누적용 변수
    float delta = 0;


    void Start()
    {
        
    }

    void Update()
    {
        // 매 프레임마다 지난 시간을 누적
        delta += Time.deltaTime;

        // 누적된 시간이 1초가 넘으면
        if(delta > span){
            // delta 초기화 하고
            delta = 0;

            // 화살 프리팹을 복사해서 새로 생성한다 -> 화살 생성
            // Instantiate 오브젝트를 복사해서 새로 생성하는 함수
            GameObject go = Instantiate(arrowprefeb);

            // 랜덤값 화살의 위치 x값
            int arrow_x = Random.Range(-6,7);

            // x좌표를 나눠서 부드러운 위치에 배치함 (-8~0.8)
            go.transform.position = new Vector3(arrow_x , 7.0f , 0);

        }
    }
}
