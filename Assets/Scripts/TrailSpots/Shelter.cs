using System.Collections;
using UnityEngine;

public class Shelter : TrailSpot
{
    public enum Behaviors
    {
        Meeting,
        Relax,
        Camp,
        Lunch
    }

    public Shelter(string spotName, Vector3 spotPosition, Vector2 altitude) : base(spotName, spotPosition, altitude)
    {
        spotName = base.SpotName;
        spotPosition = base.SpotPosition;
        altitude = base.Altitude;
    }
}
