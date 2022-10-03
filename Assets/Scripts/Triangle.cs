using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : Shape
{
    public Triangle(string pColor, string pName) : base(pColor, pName)
    {
        Color = pColor;
        Name = pName;
    }

    public override string DefineYourSelf()
    {
        string define = "A triangle is a polygon with three edges and three vertices. It is one of the basic shapes in geometry.";
        return define;
    }
}
