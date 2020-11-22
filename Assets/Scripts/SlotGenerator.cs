using System;
using System.Collections.Generic;
using UnityEngine;

public class SlotGenerator
{
    List<SpaceSlot> SlotStorage = new List<SpaceSlot>();
    
    public SlotGenerator()
    { 
        for (int i = 0; i < 10; i++)
        {
            Vector3 v = new Vector3(0, 0, i);
            SlotStorage.Add(new SpaceSlot(v,v,false,false));
        }
    }
}
