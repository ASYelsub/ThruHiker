using System;
using System.Collections.Generic;
using UnityEngine;

public class Town : TrailSpot
{
    private enum Behaviors
    {
        Meeting,
        Restock,
        Lunch,
        Camp,
        Relax
    }
    public Town(string spotName, Vector3 spotPosition, Vector2 altitude) : base(spotName, spotPosition, altitude)
    {
        spotName = base.SpotName;
        spotPosition = base.SpotPosition;
        altitude = base.Altitude;
    }
}
