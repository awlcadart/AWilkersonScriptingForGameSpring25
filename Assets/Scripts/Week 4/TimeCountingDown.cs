using UnityEngine;

public class TimeCountingDown : MonoBehaviour
{
    public float timerCountingDown = 3f;
    public float timerMaxDuration = 3f;
    public bool hasfinishedtimer;
    public GameObject cube;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (hasfinishedtimer == false)
        {
            timerCountingDown -= Time.deltaTime;
            Debug.Log(timerCountingDown);

            if (timerCountingDown <= 0)
            {
                Debug.Log("Beep Beep Beep!");
            }
            timerCountingDown += Time.deltaTime;
          
                cube.transform.position -= Vector3.right;
                timerCountingDown = 3f;
            }
        }
    }

