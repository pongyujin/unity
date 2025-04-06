using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{

    GameObject hpGauge;
    float fillamout;
    GameObject text;
    void Start()
    {
        // 일단 hp를 제외해야하니깐 오브젝트 가져오기
        hpGauge = GameObject.Find("hpGauge");

        text = GameObject.Find("Text");
    }

    void Update()
    {
        fillamout = hpGauge.GetComponent<UnityEngine.UI.Image>().fillAmount;
        
    }
    public void hpGauge_m()
    {
        hpGauge.GetComponent<UnityEngine.UI.Image>().fillAmount -= 0.1f;

        if( fillamout < 0.05){
            text.GetComponent<TextMeshProUGUI>().text = "Game Over!";
            
        }
    }

}
