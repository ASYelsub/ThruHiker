using System;
using System.Collections.Generic;
using UnityEngine;

public class SlotGenerator
{
    public List<SpaceSlot> slotStorage;
    public List<SpaceSlot> slotStorage2;

    public SlotGenerator()
    {
        slotStorage = new List<SpaceSlot>();
        slotStorage2 = new List<SpaceSlot>(); //the right side of the path, or something.
    }

    public void GenerateRandomSlots(int amount, GameObject slotPrefab, GameObject trailHolder)
    {
        int randomInt;
        for (int i = 0; i < amount; i++)
        {
            //Maybe like each camp-site will be determined, and the distance between each will be set specifically
            //but the actual positioning of the slots is random for each playthrough?
            //Lets say each slot is like one meter
            //Each level has like different parameters for like how things spawn, I think. Like the Position can be different,
            //the kinds of path can be different, the amount of other hikers can be different, et cetera.
            randomInt = UnityEngine.Random.Range(1, 10);
            float xPos = UnityEngine.Random.Range(-1f, 1f);
            float yPos = UnityEngine.Random.Range(0f, 2.5f);
            Vector3 v = new Vector3(xPos, yPos, i * 2);
            SpaceSlot newSpaceSlot = new SpaceSlot(SlotTypeFromInt(randomInt), v, v, slotPrefab, trailHolder);
            slotStorage.Add(newSpaceSlot);
            v = new Vector3(xPos + 4, yPos, i * 2);
            SpaceSlot newSpaceSlot2 = new SpaceSlot(SlotTypeFromInt(randomInt), v, v, slotPrefab, trailHolder);
            slotStorage2.Add(newSpaceSlot2);
            Debug.Log("SpaceSlot type " + newSpaceSlot.SlotType + " spawned at point" + v);
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