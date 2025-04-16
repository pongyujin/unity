using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;


public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;
    void Start()
    {
        // 유니티에 있는 hpGauge를 한번만 찾음 되니깐 Start에
        hpGauge = GameObject.Find("hpGauge");
    }

    // Update is called once per frame
    public void DecreaseHP()
    {
        hpGauge.GetComponent<UnityEngine.UI.Image>().fillAmount -= 0.1f;
    }

    public void Fail(){
        
    }
}
