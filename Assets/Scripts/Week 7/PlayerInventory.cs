using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    //public bool hasKey = false;
    public GameObject PlayerCamera;
    public bool hasRedKey = false;
    public bool hasBlueKey = false;
    public bool hasYellowKey = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //Are we looking at the door?
            RaycastHit hitObject; // This varaible containts data of what will be hit by the Raycast we're able to make.
            if (Physics.Raycast(PlayerCamera.transform.position, PlayerCamera.transform.forward, out hitObject, 10f))
            {
                if (hitObject.collider.gameObject.tag == "Door")
                {
                    Door lookedAtDoor = hitObject.collider.gameObject.GetComponent<Door>();
                    if(lookedAtDoor.doorColor == KeyColor.Red && hasRedKey ==true)
                    {
                        lookedAtDoor.OpenDoor();
                    }
                    else if(lookedAtDoor.doorColor == KeyColor.Blue && hasBlueKey == true)
                    {
                        lookedAtDoor.OpenDoor();
                    }
                    else if (lookedAtDoor.doorColor == KeyColor.Yellow && hasYellowKey == true)
                    {
                        lookedAtDoor.OpenDoor();
                    }
                   // if (hasKey == true)
                    {
                        //OpenDoor
                        //hitObject.collider.gameObject.GetComponent<Door>().OpenDoor();
                    }
                }
            }
    

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Key")
        {
            KeyColor pickedUpKeyColor = other.gameObject.GetComponent<Key>().color;
            //hasKey = true;
            if (pickedUpKeyColor == KeyColor.Red)
            {
                hasRedKey = true;
            }
            else if(pickedUpKeyColor == KeyColor.Blue)
            {
                hasBlueKey = true;
            }

            Destroy(other.gameObject);
        }
    }
}
