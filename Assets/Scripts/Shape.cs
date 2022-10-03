using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape
{
    private string _name;
    private string _color;

    public string Color 
    {
        get => _color;
        protected set => _color = value;
    }
    public string Name
    {
        get => _name;
        protected set => _name = value;
    }

    public Shape(string pColor, string pName)
    {

    }

    public string DisplayText()
    {
        string introduceYourSelf = $"My name is {Name} and my color is {Color}.\n";
        return introduceYourSelf;
    }

    public abstract string DefineYourSelf();
    
}
