﻿using System;
using System.Collections.Generic;
using UnityEngine;

public class ThruHiker : Hiker
{
    private string[] dialogue;
    private float happinessChange;

    private bool isNPCatTrailSpot;

    public ThruHiker(string codeName, float currentSpeed)
         : base(codeName, currentSpeed)
    {
        HikerGenerator.otherHikerCount++;
    }
}
