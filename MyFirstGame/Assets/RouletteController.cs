using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0.0f; // 전역변수
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // input이 마우스버튼을 눌렀을때 rotspeed를 10으로
        if(Input.GetMouseButtonDown(0)){
            this.rotSpeed =10;
        }

        //회전 속도만큼 룰렛을 회전시킨다
        // 프레임마다 10도씩 회전
        transform.Rotate(0,0, this.rotSpeed);

        this.rotSpeed *= 0.96f;

        if(rotSpeed < 1.11111111){
            this.rotSpeed = 0;
        }
        Debug.Log("rotSpeed Value : "+ rotSpeed);
    }
}
