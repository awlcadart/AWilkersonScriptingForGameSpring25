using UnityEngine;

public class ConditionPractice : MonoBehaviour
{
    public GameObject Go;
    public GameObject Go2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ColorGameObjectByName();
        ColorGameObjectByTag();
        //Tagging 
    }

    // Update is called once per frame
    void Update()
    {

    }
    void ColorGameObjectByName()
    {
        Debug.Log("go is named" + Go.name);
        Debug.Log("go2 is named" + Go2.name);

        //Get Compoenent will look for the component on the gameObject it is being called on.
        // If there is no component of the type you are trying to get, when you use the 
        MeshRenderer gomeshRenderer = Go.GetComponent<MeshRenderer>();


        if (Go.name == "Cube")
        {
            Go.GetComponent<MeshRenderer>().material.color = Color.magenta;
            //Change the color to pink
            //GetComponent will look for the component on the gameObject it is being called on.
            //If there is no compotentn of the type you are trying to get, when you use the dot operater after it, it will throw a null reference exception,
        }
        else if (Go.name == "Sphere")
        //Change the color to cyan
        {
            gomeshRenderer.material.color = Color.cyan;
        }
        else if (Go.name == "Cylinder")
        {
            //Change the color to black
            gomeshRenderer.material.color = Color.black;
        }
        else
        {
            gomeshRenderer.material.color = new Color32(255, 150, 3, 255);
            //Change the color to orange
        }


    }

    void ColorGameObjectByTag()

    {
        MeshRenderer go2MeshRenderer = Go2.GetComponent<MeshRenderer>();
        if (Go.tag == "Cool Guy")
        {
            if (Go.tag == "Cool Guy")
            {
                Go.GetComponent<MeshRenderer>().material.color = Color.magenta;
                //Change the color to pink
                //GetComponent will look for the component on the gameObject it is being called on.
                //If there is no compotentn of the type you are trying to get, when you use the dot operater after it, it will throw a null reference exception,
            }
            else if (Go.tag == "Okay Guy")
            //Change the color to cyan
            {
                go2MeshRenderer.material.color = Color.cyan;
            }
            else if (Go.tag == "Less Cool Guy")
            {
                //Change the color to black
                go2MeshRenderer.material.color = Color.black;
            }
            else
            {
                go2MeshRenderer.material.color = new Color32(255, 150, 3, 255);
                //Change the color to orange
            }
        }

    } 
}

