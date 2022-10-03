using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shape
{
    public Circle (string pColor, string pName):base(pColor, pName)
    {
        Color = pColor;
        Name = pName;
    }

    public override string DefineYourSelf()
    {
        string define = "A circle is a shape consisting of all points in a plane that are at a given distance from a given point, the centre.";
        return define;
    }
}
