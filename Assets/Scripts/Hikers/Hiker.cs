using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class Hiker : MonoBehaviour
{
    private string firstName;
    private string lastName;
    private string codeName; //name I use in coding
    private SpaceSlot currentSlot;
    private float currentSpeed; //complexified with Camper class

   

    public Hiker(string codeName, float currentSpeed)
    {
        this.codeName = codeName;

        //firstName and lastName are dependent on codeName;
        //maybe we'll have an enum of character names or something?
        this.currentSpeed = currentSpeed;
        //For some fucking reason currentSlot refuses to be a thing that's passed through the constructor or whatever.
        
    }

    //Getters and Setters
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
    public string CodeName
    {
        get { return codeName; }
        set { codeName = value; }
    }
    public SpaceSlot CurrentSlot
    {
        get { return currentSlot; }
        set { currentSlot = value; }
    }
    public float CurrentSpeed
    {
        get { return currentSpeed; }
        set { currentSpeed = value; }
    }


    //Have to ask if this works.
    /*public string LastName { get; set; }
    public string CodeName { get; set; }
    public SpaceSlot CurrentSlot { get; set; }
    public float CurrentSpeed { get; set; }*/
}
