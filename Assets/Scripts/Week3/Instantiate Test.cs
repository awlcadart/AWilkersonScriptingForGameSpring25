using UnityEngine;

public class InstantiateTest : MonoBehaviour
{
    public GameObject CannonBallPrefab;
    public GameObject cbSpawnPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //Instantiate means spawning an instance of an object 
    void Start()
    {
        Instantiate(CannonBallPrefab, cbSpawnPosition.transform.position, Quaternion.identity);
        // Creates instance of that object
        //This instantiated version spawns the cannonBall prefab, at the spawn position.
        // with the same rotation of the object identity.
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {

            Instantiate(CannonBallPrefab);
        } 
    }
}
