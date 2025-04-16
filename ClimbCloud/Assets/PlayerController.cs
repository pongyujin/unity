using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; // LoadScene을 사용하는 데 사용한다

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    public float jumpForce = 680.0f;

    public float walkForce = 30.0f;
    public float maxWalkSpeed = 2.0f;

    void Start()
    {
        Application.targetFrameRate = 60;
        // 가져옴
        rigid2D = GetComponent<Rigidbody2D>();
        
        animator = GetComponent<Animator>();
        //print(transform.up);
    }

    void Update()
    {
        // 점프한다
        // transform.up 은 0,1,0 이다
        // jumpForce 는 680f 여서 1*600 = 680f 이다
        //if(Input.GetKeyDown(KeyCode.Space)){
            //rigid2D.AddForce(transform.up * jumpForce);
        //};
        
        
        // 스페이스를 눌렀을때, player가 y좌표가 0일때
        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rigid2D.linearVelocity.y) < 0.01f)
        {
            rigid2D.AddForce(Vector2.up * jumpForce);
        }


        // 좌우 이동
        int key = 0;
        if(Input.GetKey(KeyCode.RightArrow)) key = 1;
        if(Input.GetKey(KeyCode.LeftArrow)) key = -1;


        float speedx = Mathf.Abs(rigid2D.linearVelocity.x);

        if (speedx < maxWalkSpeed){
            rigid2D.AddForce(transform.right * key * walkForce);
        }

        if (key != 0){
            transform.localScale = new Vector3(key, 1, 1);
        }
        
        // 플레이어 속도에 맞춰 애니메이션 속도를 바꾼다
        animator.speed= speedx / 2.0f;
        
        // 플레이어가 화면 밖으로 나갔다면 처음부터
        if(transform.position.y < -10){
            SceneManager.LoadScene("GameScene");
        }

    }
    
    void OnTriggerEnter2D(Collider2D collsion){
        print("골~~~");
        SceneManager.LoadScene("ClearScene");
        
   }
}
