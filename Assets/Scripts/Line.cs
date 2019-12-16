using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//for linear interpolation i.e. LERP (Vector3.LERP)


public class Line
{
    //parametric form of a line
    Coords A;
    Coords B;
    Coords v;
    //type determines the range of t for the appropriate line you are using:
    public enum LINETYPE {LINE, SEGMENT, RAY };
    LINETYPE type;

    public Line(Coords _A, Coords _B, LINETYPE _type)
    {
        A = _A;
        B = _B;
        type = _type;
        v = new Coords(B.x - A.x,B.y - A.y, B.z - A.z);

    }

    //construct a new point along the line with t value
    public Coords lerp(float t)
    {

        if(type == LINETYPE.SEGMENT)
        {
            t = Mathf.Clamp(t, 0, 1);

        }
        else if (type == LINETYPE.RAY && t < 0)
        {
            //because a ray has a start of '0' and an end of infinite, we only need to check the start value
            t = 0;

        }


        float xt = A.x + v.x * t;
        float yt = A.y + v.y * t;
        float zt = A.z + v.z * t;

        return new Coords(xt, yt, zt);
    }
}
