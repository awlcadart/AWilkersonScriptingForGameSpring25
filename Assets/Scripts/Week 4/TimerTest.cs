using UnityEngine;

public class TimerTest : MonoBehaviour
{
    public float timerCountingUp = 0f;
    public float timerMaxDuration = 3f;
    public bool hasfinishedtimer = false;
    public GameObject cube;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("MoveCubeRight", timerMaxDuration);
        // When using random.range, if you put f after the numbers in function it will
        //return a decimal number between those two numbers, if you do NOT put an f after
        // it will return a whole number, first number to the last not including the last number
        // example random range (1,4) will return 1,2,3, but not 4.
        // if you do random range ( 1f, 4f) it will return anywhere between 1 and 4, including decimeal places like 1,759.
        timerMaxDuration = Random.Range(1f, 4f);

    }

    // Update is called once per frame
    // In this update, once the timer finished, it changes a bool called hasfinished timer
    // to true, which prevents additonal logic being run for the timer.
    //This is how you can make sure something only happedns ONCE based on timer.
    /*
    void Update()
    {
        if (hasfinishedtimer == false)
        {
            timerCountingUp += Time.deltaTime;
            Debug.Log(timerCountingUp);

            if (timerCountingUp >= timerMaxDuration)
            {
                Debug.Log("Beep Beep Beep!");
            }
        }
    }
    */
    //In this Update, the timer counts up, but once it finally reaches the timeMaxDuration
    // it will move the cube to the right WITHOUT time.deltatime because we want it to move
    // in one motion , not over time. Additionally, we reset the timecounting up to 0 so that 
    // it will count back up to 3 again and move the cube once more. 
    void Update()
    {/*
        
            timerCountingUp += Time.deltaTime;
            Debug.Log(timerCountingUp);

            if (timerCountingUp >= timerMaxDuration)
            {
                Debug.Log("Beep Beep Beep!");
            MoveCubeRight();
            cube.transform.position += Vector3.right;
            timerCountingUp = 0f;
            }*/
    }
    void MoveCubeRight()
    {
        cube.transform.position += Vector3.right;
        if (cube.transform.position.x < 10)
        {
            Invoke("MoveCubeRight", timerMaxDuration);
        }
    }
}
    
