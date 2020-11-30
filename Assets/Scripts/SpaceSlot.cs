using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class SpaceSlot : MonoBehaviour
{

    public enum SlotTypes
    {
        //to add more types you also need to go into slotGenerator and edit:
        //slotTypeFromInt and the top range of intRandom
        Rocky,
        Cairn,
        WellCaredFor,
        Concrete,
        Bridge,
        Log,
        Stream,
        Flooded,
        Steep,
        Nothing
    }

    //unsure what to do with this other than like it'll interact
    //w the visual part of Unity?

    private SlotTypes slotType;
    private Hiker hikerInFirstPoint;
    private Hiker hikerInSecondPoint;
    private Vector3 firstPointInSpace; //where character slots into, usually the kids, on "the left" of trail
    private Vector3 secondPointInSpace; //where a second character slots into... eithr a kid or another hiker
                                        //can be irritating for other hikers if kid slots into here and they cant pass
    private bool firstPointFilled; //if a character is currently at the location
    private bool secondPointFilled;
    private SlotTypes slotTypes;
    private Vector3 v1;
    private Vector3 v2;

    public SpaceSlot(SlotTypes slotType, Vector3 firstPointInSpace, Vector3 secondPointInSpace, GameObject slotPrefab, GameObject trailHolder)
    {
        this.slotType = slotType;
        this.firstPointInSpace = firstPointInSpace;
        this.secondPointInSpace = secondPointInSpace;
        this.firstPointFilled = false;
        this.secondPointFilled = false;
        Instantiate(slotPrefab, firstPointInSpace, Quaternion.identity, trailHolder.transform);

    }

    public void PutHikerInFirstPoint(Hiker hiker)
    {
        if(hikerInFirstPoint == null)
        {
            this.hikerInFirstPoint = hiker;
        }
        else
        { 
            Console.WriteLine(this.hikerInFirstPoint.CodeName + "is already in this slot's first point.");
            PutHikerInSecondtPoint(hiker);
            Console.WriteLine("Attempting to put " + hiker + " in second point.");
        }

    }

    public void PutHikerInSecondtPoint(Hiker hiker)
    {
        if (HikerInSecondPoint == null)
        {
            this.HikerInSecondPoint = hiker;
        }
        else
        {
            Console.WriteLine(this.hikerInSecondPoint.CodeName + "is already in this slot's second point.");
        }

    }


    //Getters and Setters
    public SlotTypes SlotType
    {
        get { return slotType; }
        set { slotType = value; }
    }
    public Hiker HikerInFirstPoint
    {
        get { return hikerInFirstPoint; }
        set { hikerInFirstPoint = value; }
    }
    public Hiker HikerInSecondPoint
    {
        get { return hikerInSecondPoint; }
        set { hikerInSecondPoint = value; }
    }
    public Vector3 FirstPointInSpace
    {
        get { return firstPointInSpace; }
        set { firstPointInSpace = value; }
    }
    public Vector3 SecondPointInSpace
    {
        get { return secondPointInSpace; }
        set { secondPointInSpace = value; }
    }
    public bool FirstPointFilled
    {
        get { return firstPointFilled; }
        set { firstPointFilled = value; }
    }
    public bool SecondPointFilled
    {
        get { return secondPointFilled; }
        set { secondPointFilled = value; }
    }
}
