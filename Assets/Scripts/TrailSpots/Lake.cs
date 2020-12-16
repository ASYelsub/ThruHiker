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
    public Lake(string spotName, Vector3 spotPosition, Vector2 altitude) : base(spotName, spotPosition, altitude)
    {
        spotName = base.SpotName;
        spotPosition = base.SpotPosition;
        altitude = base.Altitude;
    }


}
