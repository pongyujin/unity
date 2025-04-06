using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 1.0f;
    float delta = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if(delta > span){
            delta =0;
            GameObject go = Instantiate(arrowPrefab) as GameObject;
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }
    }
}
