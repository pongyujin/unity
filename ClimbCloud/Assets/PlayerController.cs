using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    public float jumpForce = 200.0f;

    public float walkForce = 20.0f;
    public float maxWalkSpeed = 1.0f;

    void Start()
    {
        // 가져옴
        rigid2D = GetComponent<Rigidbody2D>();
        print(transform.up);
    }

    void Update()
    {
                // 점프한다 
        // transform.up 은 0,1,0 이다
        // jumpForce 는 680f 여서 1*600 = 680f 이다
        if(Input.GetKeyDown(KeyCode.Space)){
            rigid2D.AddForce(transform.up * jumpForce);
        };

        // 좌우 이동
        int key = 0;
        if(Input.GetKey(KeyCode.RightArrow)) key = 1;
        if(Input.GetKey(KeyCode.LeftArrow)) key = -1;

        float speedx = Mathf.Abs(rigid2D.velocity.x);

        if (speedx < maxWalkSpeed){
            rigid2D.AddForce(transform.right * key * walkForce);
        }

        if (key != 0){
            transform.localScale = new Vector3(key, 1, 1);
        }

    }
}
