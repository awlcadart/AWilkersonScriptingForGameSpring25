using UnityEngine;

public class MovementTest : MonoBehaviour
{

    public Vector2 startingPosition;
    public Vector3 movedirection;
    punlic float speed; 
    // 2 Slashes and the green text after are called comments. This is not coce that runs. it is usually used for notes.
    //Characers are only allowed to be 1 letter or character on a keyboard. Make sure to use
    //an postropher to surron the character you want it to represent! 
    // A string is technically a string of characters, which could mean a word or an entire paragraph!
    //Make sure to use quotation marks to say what the string is. 
   // Math is pusing using symbols and with numbers of same type. Try to keep intergers with intergers.
   // You can mix and match literal numbers in math with variables. Try and keep most things as variable respresentations of numbers!
   //
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Start is called when this object first exists in the scene and the game is loaded.
    void Start()
    {
        Debug.Log("Hello World!");

        //in reference to the object THIS script is on, get reference to its TRANSFORM component
        // and get reerence to the transform's POSITION, and SET it (=) to Vector.zero (which means 0,0,0)
        this.transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        //current position is 0,0,0
        this.transform.position += movedirection * speed * Time.deltaTime;        
        Debug.Log("I am hungry!");   

        // Time.Delta 
    }
}
