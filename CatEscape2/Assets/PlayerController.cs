using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate =60;
    }

    void Update()
    {
        // 1. 왼쪽 키를 눌렀을 떄 움직인다
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            transform.Translate(-3,0,0);
        }

        // 2. 오른쪽 키를 눌렀을 떄 움직인다
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            transform.Translate(3,0,0);
        }

        // 3. 위쪽 키를 눌렀을 때 움직인다
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            transform.Translate(0,3,0);
        }

        // 4. 밑에 키를 눌렀을 때 움직인다
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            transform.Translate(0,-3,0);
        }

    }

    public void LButton() {
        transform.Translate(-3,0,0);
    }

    public void RButton() {
        transform.Translate(3,0,0);
    }
}
