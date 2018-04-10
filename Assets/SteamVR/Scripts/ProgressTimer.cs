using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ProgressTimer : MonoBehaviour
{
    Image fillImg;
    float timeAmt = 10;
    float time;

    // Use this for initialization
    void Start()
    {
        fillImg = this.GetComponent<Image>();
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (time <= 10)
        {
            time += Time.deltaTime;
            fillImg.fillAmount = time / timeAmt;
        }
    }
}