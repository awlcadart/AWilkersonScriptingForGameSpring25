using UnityEngine;
using System.Collections.Generic;

public class Boo : MonoBehaviour
{
    public GameObject Booprefab;
    public Transform BooSpawn;

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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
