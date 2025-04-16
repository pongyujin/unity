using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 0.5f;
    float delta = 0; //
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 한프레임당 더한다 60분의 1초
        delta += Time.deltaTime;

        if(delta > span){
            delta = 0.0f;
            GameObject go = Instantiate(arrowPrefab) as GameObject; //
            int px = Random.Range(-6,7);
            go.transform.position = new Vector3(px,7,0);
        }
        // 유니티에 생서ㅇ됨
    }
}
