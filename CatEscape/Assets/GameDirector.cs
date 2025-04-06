using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;
    void Start()
    {
        hpGauge = GameObject.Find("hpGauge");
    }

    // Update is called once per frame
    public void DecreaseHP()
    {
        hpGauge.GetComponent<UnityEngine.UI.Image>().fillAmount -= 0.1f;
    }
}
