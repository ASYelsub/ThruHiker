using System;
using System.Collections.Generic;
using UnityEngine;

public class SlotGenerator
{
    List<SpaceSlot> SlotStorage;

    public SlotGenerator()
    {
        SlotStorage = new List<SpaceSlot>();
    }

    public void GenerateRandomSlots(int amount)
    {
        int randomInt;
        for (int i = 0; i < amount; i++)
        {
            randomInt = UnityEngine.Random.Range(1, 10);
            Vector3 v = new Vector3(0, 0, i);
            SpaceSlot newSpaceSlot = new SpaceSlot(SlotTypeFromInt(randomInt), v, v);
            SlotStorage.Add(newSpaceSlot);
            Debug.Log("SpaceSlot type " + newSpaceSlot.SlotType + " added to SlotStorage.");
        }
    }

    public SpaceSlot.SlotTypes SlotTypeFromInt(int input)
    {
        switch (input)
        {
            case 1:
                return SpaceSlot.SlotTypes.Rocky;
            case 2:
                return SpaceSlot.SlotTypes.Cairn;
            case 3:
                return SpaceSlot.SlotTypes.WellCaredFor;
            case 4:
                return SpaceSlot.SlotTypes.Concrete;
            case 5:
                return SpaceSlot.SlotTypes.Bridge;
            case 6:
                return SpaceSlot.SlotTypes.Log;
            case 7:
                return SpaceSlot.SlotTypes.Stream;
            case 8:
                return SpaceSlot.SlotTypes.Flooded;
            case 9:
                return SpaceSlot.SlotTypes.Steep;
            default:
                return SpaceSlot.SlotTypes.Nothing;
        }

    }
}