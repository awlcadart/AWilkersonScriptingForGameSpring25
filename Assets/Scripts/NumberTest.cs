using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberScript : MonoBehaviour
{
    int Apple;
    public float Peaches = 2.2f;
    char P;
    string intro = "Hello!";
    string total;
    string outro;
    string fullSentence;
    // Start is called before the first frame update
    void Start()
    {
        Apple = 42;

        Apple = (Apple +10) * 5 / (6-10);

        Debug.Log (Peaches);

        Debug.Log(Apple);

        Peaches = Peaches - 7;
        Debug.Log ("The ammount of peaches you have is" + Peaches);

        Debug.Log ("P" + intro);


        total = (Apple + Peaches).ToString();

        Debug.Log (total);

        fullSentence = intro + outro;

        Debug.Log(fullSentence);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
