using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0.0f;
    Vector2 startPos;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
    //     if(Input.GetMouseButtonDown(0)){ //마우스를 클릭하면
    //         this.speed = 0.2f; //처음 속도를 설정한다
    //     }
    // transform.Translate(this.speed, 0.0f,0.0f); //이동
    // this.speed *= 0.98f;
    
    // 만약 왼쪽버튼을 눌렀다면
    if(Input.GetMouseButtonDown(0)){
        
        // 딸!!!! 했을때의 마우스 포지션을 startPos좌표로한다
        this.startPos = Input.mousePosition;
        Debug.Log("startPos : " + startPos);

    // 만약 왼쪽버튼을 뗏다면
    }else if (Input.GetMouseButtonUp(0)){
        
        // 깍!!!!!! 했을때의 마우스 포지션을 endPos 변수에다가 저장장
        Vector2 endPos = Input.mousePosition;
        Debug.Log("endPos : " + endPos);

        float swipeLength = endPos.x - this.startPos.x;

        //스와이프 길이를 처음 속도로 변환한다.
        this.speed = swipeLength / 500.0f;

        GetComponent<AudioSource>().Play();
    }
    transform.Translate(this.speed, 0.0f,0.0f); //이동
    this.speed *= 0.98f;
    }
}
