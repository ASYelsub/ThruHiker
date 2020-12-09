using System.Collections;
using UnityEngine;


public class Lake : TrailSpot
{
    private enum Behaviors
    {
        Bathe,
        Relax,
        Meeting,
        Lunch
    }
    public Lake(string spotName, Vector3 spotPosition) : base(spotName, spotPosition)
    {
        spotName = base.SpotName;
        spotPosition = base.SpotPosition;
    }


}
