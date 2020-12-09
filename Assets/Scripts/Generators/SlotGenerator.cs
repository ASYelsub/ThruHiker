using System;
using System.Collections.Generic;
using UnityEngine;

public class SlotGenerator
{
    public List<SpaceSlot> slotStorage;
    public List<SpaceSlot> slotStorage2;

    public List<GameObject> slotPhysical;
    public List<GameObject> slotPhysical2;

    private Material slotMat;
    private HolderOfAssets assetHolder;

    private int numberOfSlotsInLevel;
    public SlotGenerator()
    {
        numberOfSlotsInLevel = 0;
        slotStorage = new List<SpaceSlot>();
        slotStorage2 = new List<SpaceSlot>(); //the right side of the path, or something.
    }

    public void GenerateRandomSlots(int amount, GameObject slotPrefab, GameObject trailHolder, HolderOfAssets assetHolder)
    {
        this.assetHolder = assetHolder;
        this.numberOfSlotsInLevel = amount;
        int randomInt;
        //PROBABLY GONNA MOVE MOST OF THIS INFO TO LEVEL
        //...or at least have it depend on a "level" object thats passed through in the signature?
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
            SpaceSlot newSpaceSlot = new SpaceSlot(SlotTypeFromInt(randomInt), v, v, slotPrefab, trailHolder,slotMat);
            slotStorage.Add(newSpaceSlot);
            v = new Vector3(xPos + 4, yPos, i * 2);
            SpaceSlot newSpaceSlot2 = new SpaceSlot(SlotTypeFromInt(randomInt), v, v, slotPrefab, trailHolder,slotMat);
            slotStorage2.Add(newSpaceSlot2);
            Debug.Log("SpaceSlot type " + newSpaceSlot.SlotType + " spawned at point" + v);
        }
    }

    public SpaceSlot.SlotTypes SlotTypeFromInt(int input)
    {
        switch (input)
        {
            case 1:
                slotMat = assetHolder.RockyMat;
                return SpaceSlot.SlotTypes.Rocky;
            case 2:
                slotMat = assetHolder.CairnMat;
                return SpaceSlot.SlotTypes.Cairn;
            case 3:
                slotMat = assetHolder.WellCaredForMat;
                return SpaceSlot.SlotTypes.WellCaredFor;
            case 4:
                slotMat = assetHolder.ConcreteMat;
                return SpaceSlot.SlotTypes.Concrete;
            case 5:
                slotMat = assetHolder.BridgeMat;
                return SpaceSlot.SlotTypes.Bridge;
            case 6:
                slotMat = assetHolder.LogMat;
                return SpaceSlot.SlotTypes.Log;
            case 7:
                slotMat = assetHolder.StreamMat;
                return SpaceSlot.SlotTypes.Stream;
            case 8:
                slotMat = assetHolder.FloodedMat;
                return SpaceSlot.SlotTypes.Flooded;
            case 9:
                slotMat = assetHolder.SteepMat;
                return SpaceSlot.SlotTypes.Steep;
            default:
                return SpaceSlot.SlotTypes.Nothing;
        }
    }

    public int NumberOfSlotsInLevel
    {
        get { return numberOfSlotsInLevel; }
        set { numberOfSlotsInLevel = value; }
    }
}