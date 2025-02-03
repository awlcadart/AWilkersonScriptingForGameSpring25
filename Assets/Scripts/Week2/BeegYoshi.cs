using UnityEngine;

public class BigYoshi : MonoBehaviour
{
    public GameObject BeegYoshi;
    public float scaleIncrease = .5f;
    public GameObject youDiedScreen;
    public Vector3 rotationAmmount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BeegYoshi.transform.localScale += Vector3.one * scaleIncrease * Time.deltaTime;

        if (BeegYoshi.transform.localScale.x > 42)
        {
            youDiedScreen.SetActive(true);
        }
    }
    public void ResetBeegYoshi()
    {
        BeegYoshi.transform.localScale = Vector3.one;
        scaleIncrease += .5f;

    }
    public void RotateBeegYoshi()
    {
        //the following line will rotate beegyoshi by -90 degrees in the z direction by creating a new vector3 variable to be used once at runtime.
        //creating a new vector3 variable to be used once at runtime.
        // alternatively, you can create a variable type of vector3 to pass into the rotate function, like in the following line. This makes it so you can change the functionality 
        BeegYoshi.transform.Rotate(new Vector3(0f, 0f, -90f));
    }
}
