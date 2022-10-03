using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle : Shape
{
    public Rectangle(string pColor, string pName) : base(pColor, pName)
    {
        Color = pColor;
        Name = pName;
    }

    public override string DefineYourSelf()
    {
        string define = "A crossed rectangle is a crossed (self-intersecting) quadrilateral which consists of" +
            "\ntwo opposite sides of a rectangle along with the two diagonals (therefore only two sides are parallel).";
        return define;
    }
}
