using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class Boo : MonoBehaviour
{
    public GameObject Booprefab;
    public Transform BooSpawn;
    public bool  hasTimerFinished;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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
          GameObject go = Instantiate(Booprefab, BooSpawn.position, BooSpawn.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        {
            GameObject go = Instantiate(Booprefab, BooSpawn.position, BooSpawn.rotation);
            Vector3 randomDirection = Vector3.zero;
            randomDirection.x = Random.Range(-1f, 1f);
            randomDirection.y = Random.Range(-1f, 1f);
            randomDirection.z = Random.Range(-1f, 1f);

            float forceMutiplier = Random.Range(100, 750);
            this.gameObject.GetComponent<Rigidbody>().AddForce(randomDirection * forceMutiplier);
        }

    }


}
    
    

