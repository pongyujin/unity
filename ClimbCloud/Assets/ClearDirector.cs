using UnityEngine;
using UnityEngine.SceneManagement; // LoadScene을 사용하는 데 사용한다

public class ClearDirector : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)){
            SceneManager.LoadScene("GameScene");
        }
    }
}
