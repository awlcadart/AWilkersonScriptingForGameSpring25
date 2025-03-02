using UnityEngine;
using System.Linq;
using System.Collections.Generic;

public class TheGame : MonoBehaviour
{

    public List<Boo> Bboos = new List<Boo>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Bboos = FindObjectsByType<Boo>(FindObjectsSortMode.None).ToList();
    }

    // This script would function for the randomization of vanish
    // vanish would be on a seperate script applied to boo directly?
    // I need to figure out a way to reference the timerhasFinished ( get component?) 

    // Update is called once per frame
    void Update()
    {
        foreach (Cannon c in Bboos)
        {

            {
                c.FireCannon();
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            for (int i = 0; i < Bboos.Count; i++)
            {
                Bboos[i].VanishBoo();
                {
                    if (i % 2 == 0)
                    {
                        Bboos[i].VanishBoo();
                    }
                }
                
            }

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            for (int i = 0; i < Bboos.Count; i++)
            {
                if (i % 2 == 1)
                    Bboos[i].BoosVanish();
                
            }

        }
        void OddBooVanish()
        {
            for (int i = 0; i < Bboos.Count; i++)
            {
                if (i % 2 == 1)
                {
                    cannons[i].FireCannon();

                }
            }
        }
        void AllBooAppear()
        {
            foreach (Boo c in cannons)
            {
                if (c.forcePower >= 4500)
                {
                    c.FireCannon();
                }
            }
        }
    }
   

}

