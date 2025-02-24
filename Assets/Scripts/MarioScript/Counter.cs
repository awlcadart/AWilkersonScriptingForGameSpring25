using TMPro;
using UnityEngine;


public class UICounter:MonoBehaviour
{
    public TextMeshProUGUI countertext;
    public int counter = 0;
    public bool allowCounting = true;
    public bool hasTimerfinished = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hasTimerfinished = true)
        {
            
           allowCounting = false;
            
        }
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            CountUp();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Countdown();
        }
    }

    void CountUp()
    {
        counter++;
        UpdateCounterUI();
    }
    void Countdown()
    {
        if (counter > 0)
        {
            counter--;
        }
        UpdateCounterUI();
    }
    void UpdateCounterUI()
    {
        
        countertext.text = counter.ToString();
    }
}
