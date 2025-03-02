using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ListTest : MonoBehaviour
{
    public List<Boo> boos = new List<Boo>();
    public GameObject booprefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        boos = FindObjectsByType<Boo>(FindObjectsSortMode.None).ToList();

        //Finds all Game in scene that has the cannonball script on it and turn it into
        // a list to be used by canonballs variable, which is a list of cannonball scripts.
        GameObject go = Instantiate(booprefab);

        GameObject.FindGameObjectsWithTag("Boos").ToList();
        //Finds all Game objects in this scene witht eh specified tag. Returns it as an array of game objects that you can convert to a list.
        
        //You can add an object directly to the list by calling the list viarables name.add();
        // It must be the same type as the list. If you have a list of game objects make sure you give it a game object.
    }

    // Update is called once per frame
    void Update()
    {
    }
}
       
 
