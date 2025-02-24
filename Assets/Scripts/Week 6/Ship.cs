using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Ship : MonoBehaviour
{

    public List<Cannon> cannons = new List<Cannon>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cannons = FindObjectsByType<Cannon>(FindObjectsSortMode.None).ToList();
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Cannon c in cannons)
        {

            {
                c.FireCannon();
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            for (int i = 0; i < cannons.Count; i++)
            {
                cannons[i].FireCannon();
                {
                    if (i % 2 ==0)
                    {
                        cannons[i].FireCannon();
                    }
                }
                // This fires all cannons using a for loop.
                // for (int i = 0; i <cannons.count; i ++)
            }
           
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            for (int i = 0; i < cannons.Count; i++)
            {
                if(i % 2 ==1)
                cannons[i].FireCannon();
                // This fires all cannons using a for loop.
                // for (int i = 0; i <cannons.count; i ++)
            }

        }
        void FireOddCannons()
        {
            for (int i = 0; i <cannons.Count; i++)
            {
                if(i % 2 ==1)
                {
                    cannons[i].FireCannon();

                }
            }
        }
        void FireAllPowerfulCannons()
        {
            foreach(Cannon c in cannons)
            {
                if(c.forcePower>= 4500)
                {
                    c.FireCannon();
                }
            }
        }
    }
    void FireAllWeakCannons()
    {
        for(int i = 0; i <cannons.Count; i++)
        {
            if (cannons[i].forcePower <4500)
            {
                cannons[i].FireCannon();
            }
        }
    }
}
   