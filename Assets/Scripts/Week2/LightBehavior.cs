using UnityEngine;

public class LightBehavior : MonoBehaviour
{
    public Light lightWeWantToChange;
    public Vector3 lightMoveDirection;
    public bool isItorIsntIt = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lightWeWantToChange.color = Color.green;
        // ChangeLightColor(Color.blue) // Whatever 
        this.gameObject.SetActive(false);
        //lightWeWantToChange.gameObject.SetActive(false);
    }   

    // Update is called once per frame
    void Update()
    {
        AdjustLight(); //The code in this function will becalled at the start of each update before moving on to the rest of the code in Update().
        Debug.Log("LightObject has been Adjusted.");

        if (Input.GetKeyDown(KeyCode.R)) // R is simply the key chosen as an example 
        {
            ChangeLightColor(Color.red);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            ChangeLightColor(Color.green);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            lightWeWantToChange.gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            lightWeWantToChange.gameObject.SetActive(true);  
        }
       
        // lightWeWantToChange.transform.position += lightMoveDirection * Time.deltaTime;
        // lightWeWantToChange.intensity += 40f * Time.deltaTime;
        //lightWeWantToChange.innerSpotAngle += 10f * Time.deltaTime;
    }

    private void AdjustLight()
    {
         lightWeWantToChange.transform.position += lightMoveDirection * Time.deltaTime;
         lightWeWantToChange.intensity += 40f * Time.deltaTime;
         lightWeWantToChange.innerSpotAngle += 10f * Time.deltaTime;
    }

    public void ChangeLightColor(Color SantaClaus)
    {
        lightWeWantToChange.color = SantaClaus;
    }
    private void OnEnable()
    {
        //When this object is set active again from inactive, it will call the code in this function.
    }

    private void Awake()
    {
        //Is called before start
    }
    private void OnDestroy()
    {
        //This is called when an object is going to be destroyed before it is finished being destroyed.
    }
}
