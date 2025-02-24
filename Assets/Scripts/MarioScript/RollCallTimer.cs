using UnityEngine;
using TMPro;

public class RollCallTimer : MonoBehaviour
{
    public float timer = 30f;
    public TextMeshProUGUI timerText;
    public bool hasTimerFinished = false;
    public UICounter counterscript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasTimerFinished == false)
        {
            if (timer >1)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                hasTimerFinished = true;
                counterscript.allowCounting = false;
                timer = 0f;
            }
            
            timerText.text = Mathf.Ceil(timer).ToString("F0");
        }
    }
}
