using UnityEngine;

public class Cannonball : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision otherObject)
    {
        Debug.Log(otherObject.gameObject.name);
        if (otherObject.gameObject.tag == "floor")
        {
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
            otherObject.gameObject.GetComponent<MeshRenderer>().material.color = Color.magenta;
            otherObject.gameObject.GetComponent<Floor>().SayHello();
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //tagging triggers helps
        Debug.Log(other.gameObject.name);
        this.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
    }
}
