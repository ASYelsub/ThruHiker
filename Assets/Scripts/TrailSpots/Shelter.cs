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

    public Shelter(string spotName, Vector3 spotPosition) : base(spotName, spotPosition)
    {
        spotName = base.SpotName;
        spotPosition = base.SpotPosition;
    }
}
