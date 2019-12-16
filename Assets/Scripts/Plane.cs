using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{

    //A,B,C coords for the points on a plane
    Coords A;
    Coords B;
    Coords C;
    //vectors:
    Coords v;
    Coords u;


    public Plane(Coords _A, Coords _B, Coords _C)
    {
        A = _A;
        B = _B;
        C = _C;
        //using the minus symbol redirects to the overloaded 'operator-' function in Coords.cs
        //finding A from two other points
        v = B - A;
        u = C - A;  
    }

    public Plane(Coords _A, Vector3 V, Vector3 U)
    {
        A = _A;
        v = new Coords(V.x, V.y, V.z);
        u = new Coords(U.x, U.y, U.z);
    }


    //Parametic equation of a plane
    //P(s, t) = A + vs + ut
    public Coords Lerp(float s, float t)
    {
        float xst = A.x + v.x * s + u.x * t;
        float xyt = A.y + v.y * s + u.y * t;
        float xzt = A.z + v.z * s + u.z * t;

        return new Coords(xst, xyt, xzt);

    }

}
