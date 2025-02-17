using UnityEngine;

public class MoveObjectWithDirections : MonoBehaviour
{
    public GameObject Point1;
    public GameObject Point2;
    public float speed = 4f;
    public bool hasReachedDestination = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    //void Update()

    // THis gets the direction every frame. updating when point 1 moves
    //This causes the point 1 object to steadily creep towards point 2, slowing down
    //as it approaches because the direction is slowly getting smalled 
    //Vector3 direction;
    // This version normalizes the direction of the movement vector, so it travels steadily toward point 2, multipled by a speed variable so it can speed up.
    // it jitters as it reaches the end because it always moves past the exact location of point 2, so it goes back and forth until it tries to reach the exact point.
    ///direction = Point2.transform.position - Point1.transform.position;
    //Debug.Log(direction);

    //Point1.transform.position += direction * speed * Time.deltaTime;
}

/*
private void Update()
{
//In this version of the update, we check the distance between point 1 and point 2. If it is close enough (within .1 unit),
// it teleports point 1 onto point2, which is visually not  
    Vector3 direction;
    direction = Point2.transform.position - Point1.transform.position;

    direction = direction.normalized;
    Debug.Log(direction);
    Debug.Log (Vector3.Distance(Point1.transform.position, Point2.transform.position));
    //will return value of distance formula 

    if (Vector3.Distance(Point1.transform.position, Point2.transform.position) < .1f);
    {
        Point1.transform.position = Point2.transform.position;
        hasReachedDestination = true;
    }
    else
    {
        Point1.transform.position += direction * speed * Time.deltaTime;
    }
    Point1.transform.position += direction * Time.deltaTime;

}
*/
//This version of Update will only run if point1 hasnt reached its destination. Now it will stop running all code in update once it has reached its destination
// because we have this hspjajopasdodasojd
//if (hasReachedDestination == false) ;
    

