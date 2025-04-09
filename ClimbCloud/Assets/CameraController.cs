using UnityEngine;

public class CameraController : MonoBehaviour
{
 GameObject player;
 void Start(){
    player = GameObject.Find("cat_0");
 }
 
 void Update(){
 
    // 플레이어 위치 저장
    Vector3 playerPos = player.transform.position;
    
    // 카메라 x좌표 , y좌표를 플레이어 좌표로
    transform.position = new Vector3 ( transform.position.x, playerPos.y, transform.position.z );
 }
}
