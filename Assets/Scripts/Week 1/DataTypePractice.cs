using UnityEngine;

public class DataTypePractice : MonoBehaviour
{
    int santaClaus;
    public float yoshi = 4.8f;
    char bee = 'B';
    string intro = "Hello World!";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        santaClaus = 56;
        santaClaus = santaClaus + 5;


        Debug.Log(santaClaus);
        Debug.Log(yoshi);

        yoshi = yoshi - 2;
        Debug.Log("yoshi's value is' + yoshi);
            Debug.Log(bee + intro);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
