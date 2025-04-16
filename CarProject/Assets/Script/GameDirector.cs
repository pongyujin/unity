using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    
    GameObject car;
    GameObject flag;
    GameObject Distance;
    void Start()
    {
        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
        Distance = GameObject.Find("Distance");
    }

    
    void Update()
    {
        // flag의 트랜스폼.포지션.x값가져와라 - car.트랜스폼.포지션.x값가져와라 그 값을 length 변수에 저장하겠다
        float length = this.flag.transform.position.x - this.car.transform.position.x;

        // 
        // "F2" = 소수점 2자리까지
        this.Distance.GetComponent<TextMeshProUGUI>().text = "Distance : " + length.ToString("F2") + "m";
    }
}
