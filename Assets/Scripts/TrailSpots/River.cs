using System.Collections;
using UnityEngine;

public class River : TrailSpot //same function as concept of "waterfall"
{
    private enum Behaviors
    {
        RefillWater,
        Bathe
    }
    public River(string spotName, Vector3 spotPosition, Vector2 altitude) : base(spotName, spotPosition, altitude)
    {
        spotName = base.SpotName;
        spotPosition = base.SpotPosition;
        altitude = base.Altitude;
    }
}
