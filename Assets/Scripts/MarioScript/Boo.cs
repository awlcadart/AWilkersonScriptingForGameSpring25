using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class Boo : MonoBehaviour
{

    public bool  hasTimerFinished;
    public Vector3 randomDirection = Vector3.zero;
    public float speed = 20f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("Vanish", Random.Range(1f, 10f));
      // IvokeRepeating(name of(Booprefab), 2, 2);
        //InvokeRepeating repeats this action every X seconds)
       //CancelInvoke
        GetComponent<MeshRenderer>().enabled = true;
        //Insantiate prefab, position.rotation
        //Invoke 
        // I think the statements for this would be : When timer reaches X seconds random boos will turn off mesh rendered then after X time has elapsed it will be turned back on.
        // // reference would probably callout rollcalltimer and if timer is zero ALL boos renders are turned back on.
        //  GameObject go = Instantiate(Cannonballprefa, cannonballSpawnPosition.position, cannonballSpawnPosition.rotation);
        // GameObject go = Instantiate(BooPrefab, BooSpawn.position, BooSpawn.rotation)
        //    void vanish then reference what that is so: mesh renderer turning off and on.
        // randomDirection x = (1,1,1)
        //

        randomDirection.x = Random.Range(-1f, 1f);
       
        randomDirection.z = Random.Range(-1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.GetComponent<Rigidbody>().AddForce(randomDirection * speed * Time.deltaTime);
    }
    public void StartGame()
    {
        {
            

            float forceMutiplier = Random.Range(100, 750);
            
        }

    }
    public void BooMover()
    {
        randomDirection.x = Random.Range(-1f, 1f);

        randomDirection.z = Random.Range(-1f, 1f);
    }
    public void Appear()
    {
        GetComponent<MeshRenderer>().enabled = true;
        Invoke("Vanish", Random.Range(5f, 10f));
        BooMover();
        
    }
    public void Vanish()
    {
        GetComponent<MeshRenderer>().enabled = false;
        Invoke("Appear", 1f);
    }

}
    
    

