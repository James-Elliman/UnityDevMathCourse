using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        //translating in the Y axis with a 3D vector
        //transform.Translate(0, translation, 0);
        transform.position = HolisticMath.Translate(new Coords(transform.position), new Coords(transform.up),
            new Coords(0, translation, 0)).ToVector();
        //no rotation in the x and y axes, negative rotation in the z axis
        //transform.Rotate(0, 0, -rotation);
        //must convert to radians others the degrees by default will rotate the object too much:
        transform.up = HolisticMath.Rotate(new Coords(transform.up), rotation * Mathf.Deg2Rad, true).ToVector();
    }
}
