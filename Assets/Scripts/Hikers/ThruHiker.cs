using System;
using System.Collections.Generic;
using UnityEngine;

public class ThruHiker : Hiker
{
    private string[] dialogue;
    private float happinessChange;

    public ThruHiker(string codeName, float currentSpeed, SpaceSlot currentSlot, GameObject hikerPrefab)
         : base(codeName, currentSpeed, currentSlot, hikerPrefab)
    {
    }
}
