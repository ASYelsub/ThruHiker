using System;
using System.Collections.Generic;
using UnityEngine;

public class SlotGenerator : MonoBehaviour
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
        for (int i = 0; i < amount; i++)
        {
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

    public void GenerateSlotsInCurrentStretch(Stretch currentStretch, GameObject slotPrefab, GameObject trailHolder, HolderOfAssets assetHolder,float compareShift, GameObject spotPrefab)
    {
        this.assetHolder = assetHolder;
        this.numberOfSlotsInLevel = currentStretch.AmountOfSlotsInLevel;
        int randomInt;

        float trailEndAlt = currentStretch.StartingSpot.Altitude.x;
        float trailStartAlt = currentStretch.EndSpot.Altitude.x;

        float slotSpacerZ = 1.2f;
        float slotSpacerX = 1f;
        float slotSpacerY = 1f;

        float priorSlotPosX = 0;
        float priorSlotPosY = 0;

        float yIncrement = -.1f * ((trailEndAlt - trailStartAlt) / NumberOfSlotsInLevel);
        float xIncrement = -10000 * (currentStretch.StartingSpot.SpotPosition.x -
            currentStretch.EndSpot.SpotPosition.x) / NumberOfSlotsInLevel;
        Debug.Log("yInc = " + yIncrement);
        Debug.Log("xInc = " + xIncrement);

        float xPos = 0;
        float yPos = 0;

        int randomX;
        int randomY;
        bool thisXPos = true;
        bool lastXPos = true;
        bool thisYPos = true;
        bool lastYPos = true;

        //float endAltSpot = currentStretch.EndSpot.Altitude.x - currentStretch.StartingSpot.Altitude.x;

        Instantiate(spotPrefab, new Vector3(compareShift,1.5f,-2), Quaternion.identity);
        Instantiate(spotPrefab, new Vector3(0,trailEndAlt,0), Quaternion.identity);

        //can increase numberOfSlotsInLevel 2x if it doesn't feel long enough per trail stretch or whatever.
        for (int i = 0; i < numberOfSlotsInLevel; i++)
        {
            randomInt = UnityEngine.Random.Range(0, 9); //note: first slot was pink once for some reason? whats up w mat? all the others werent, so it has to do w assigning before smth


            randomX = UnityEngine.Random.Range(0, 2);
            if (randomX == 0)
            {
                thisXPos = true;
                if (lastXPos)
                {
                    xPos = priorSlotPosX + 
                        UnityEngine.Random.Range(currentStretch.WindingMin, currentStretch.WindingMax);
                }
                else
                {
                    xPos = priorSlotPosX + 
                        .1f * UnityEngine.Random.Range(currentStretch.WindingMin, currentStretch.WindingMax);
                }
            }
            else
            {
                thisXPos = false;
                if (!lastXPos)
                {
                    xPos = priorSlotPosX -
                        UnityEngine.Random.Range(currentStretch.WindingMin, currentStretch.WindingMax);
                }
                else
                {
                    xPos = priorSlotPosX -
                        .1f * UnityEngine.Random.Range(currentStretch.WindingMin, currentStretch.WindingMax);
                }
            }
            //xPos = xPos + xIncrement;
            priorSlotPosX = xPos;
            lastXPos = thisXPos;

            randomY = UnityEngine.Random.Range(0, 2);
            if (randomY == 0)
            {
                thisYPos = true;
                if (lastYPos)
                {
                    yPos = priorSlotPosY +
                        UnityEngine.Random.Range(currentStretch.BumpMin, currentStretch.BumpMax);
                }
                else
                {
                    yPos = priorSlotPosY +
                        .1f * UnityEngine.Random.Range(currentStretch.BumpMin, currentStretch.BumpMax);
                }
            }
            else
            {
                thisYPos = false;
                if (!lastYPos)
                {
                    yPos = priorSlotPosY -
                        UnityEngine.Random.Range(currentStretch.BumpMin, currentStretch.BumpMax);
                }
                else
                {
                    yPos = priorSlotPosY -
                        .1f * UnityEngine.Random.Range(currentStretch.BumpMin, currentStretch.BumpMax);
                }
            }
            if (i != 0)  //so it doesnt start above 0... maybe do this for x values also? but also idc. brain dead.
            {
                
                yPos = yPos + yIncrement;
            }
            priorSlotPosY = yPos;
            lastYPos = thisYPos;




            Vector3 v = new Vector3((xPos * slotSpacerX) + compareShift, yPos * slotSpacerY, i * slotSpacerZ);
            SpaceSlot newSpaceSlot = new SpaceSlot(SlotTypeFromInt(randomInt), v, v, slotPrefab, trailHolder, slotMat);
            slotStorage.Add(newSpaceSlot);

            






            //v = new Vector3(xPos * slotSpacerX, yPos * slotSpacerY, i * slotSpacerZ);
            //SpaceSlot newSpaceSlot2 = new SpaceSlot(SlotTypeFromInt(randomInt), v, v, slotPrefab, trailHolder, slotMat);
            //slotStorage2.Add(newSpaceSlot2);
            //Debug.Log("SpaceSlot type " + newSpaceSlot.SlotType + " spawned at point" + v);
        
        
            //we dont necessarily want it to be linear. we want it to be from the altitude on the starting spot to the altitude
            //on the end spot

                
        }
    }


    //Maybe like each camp-site will be determined, and the distance between each will be set specifically
    //but the actual positioning of the slots is random for each playthrough?
    //Lets say each slot is like one meter
    //Each level has like different parameters for like how things spawn, I think. Like the Position can be different,
    //the kinds of path can be different, the amount of other hikers can be different, et cetera.

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