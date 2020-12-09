using System.Collections;
using UnityEngine;

public class River : TrailSpot //same function as concept of "waterfall"
{
    private enum Behaviors
    {
        RefillWater,
        Bathe
    }
    public River(string spotName, Vector3 spotPosition) : base(spotName, spotPosition)
    {
        spotName = base.SpotName;
        spotPosition = base.SpotPosition;
    }
}
