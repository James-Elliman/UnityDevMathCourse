using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    public float rotationSpeed = 1.0f;
    public float speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
       // float translateX = Input.GetAxis("Horizontal") * speed;
       // float translateY = Input.GetAxis("VerticalY") * speed;
       // float translateZ = Input.GetAxis("Vertical") * speed;


        float rotationX = Input.GetAxis("Vertical") * speed;
        float rotationY = Input.GetAxis("Horizontal") * speed;
        float rotationZ = Input.GetAxis("HorizontalZ") * speed;
        float translateZ = Input.GetAxis("VerticalY") * speed;

        /*transform.Translate(translateX,0,0);
        transform.Translate(0, translateY,0);
        transform.Translate(0,0,translateZ);*/

        //translateX, Y and Z are in the world space
        //  transform.position = new Vector3(transform.position.x + translateX,
        //    transform.position.y + translateY, transform.position.z + translateZ);

        //Eulor angles to rotate the plane in the Yaw, Pitch and Roll:
       // transform.Rotate(rotationX,0,0);
      //  transform.Rotate(0,rotationY,0);
        //transform.Rotate(0,0,rotationZ);

        transform.Rotate(rotationX, rotationY, rotationZ);
        //only need the z-axis so that you are moving forward into the open space:
        transform.Translate(0, 0, translateZ);



    }

}
