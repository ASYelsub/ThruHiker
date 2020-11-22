using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceSlot
{
    private Vector3 firstPointInSpace; //where character slots into
    private Vector3 secondPointInSpace; //where a second character slots into... eithr a kid or another hiker
    private bool firstPointFilled; //if a character is currently at the location
    private bool secondPointFilled;


    public SpaceSlot(Vector3 firstPointInSpace, Vector3 secondPointInSpace, bool firstPointFilled, bool secondPointFilled)
    {
        this.firstPointInSpace = firstPointInSpace;
        this.secondPointInSpace = secondPointInSpace;
        this.firstPointFilled = firstPointFilled;
        this.secondPointFilled = secondPointFilled;
    }
}
