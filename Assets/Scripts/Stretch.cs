using System;
using System.Collections.Generic;
using UnityEngine;

public class Stretch
{
    
    private int stretchID; //QUESTION: Should every day be another level? Can the player take days off? How much of the work can the player plan vs how much
                                //is predisposed by me? Like should the player plan how much food is brought also?
                                   //Maybe this stuff doesn't matter, just because I want to focus on the social interactions and leave more room to gamify that.
                                   //But I really do like giving the player this intense caretaking responsiblity with time spent/food stored/etc.
                                   //Also how much is the player responsible vs the camp they work for? Are they on a specific time frame?
                                   //These are all important questions that I need to spend some good time muching on, that I have been for the past while.
                                //I definitely know that I want one "level" to be between two different stopping points on the map, so they're definitely distance
                                //based. But what if the player could plan where they can start and end? I don't think, programming-wise, it would be too
                                //different for me. Like I can still have different "levels" have different incline/events/types of slots
                                //be randomly generated and such depending on where they are in the map, but maybe instead of naming them "levels" i can
                                //name it like, "stretches" or something. 
                                    //Yeah. We're going to do that.
    private float distanceInMiles;
    private TrailSpot startingSpot;
    private TrailSpot endSpot;
    private string nameOfStartingLocation;
    private string nameOfEndLocation;
    private Vector3 startingLocationPos;
    private Vector3 endLocationPos;

    private int amountOfSlotsInLevel; //will be determined by like... distanceInMiles
    private float bumpMax; //the biggest difference two slots can be from one another on the y
    private float bumpMin;
    private float windingMax; //completely eyeballed
    private float windingMin;


    private List<SpaceSlot> specificSlotAdvent; //if i want to program in like a bunch of cairn slots near one another or like a really steep mountain
    private bool isSpecific; //if an advent of slots is random or specific
    private List<SpaceSlot> allSlotsInStretch; //corresponds to amountOfSlots

    private List<ThruHiker> otherHikersInStretch; //all of the other thru hikers
    private List<ThruHiker> specificHikersInStretch; //thru hikers that have non-generic interactions w player/campers

    public SlotGenerator slotGenerator;
    //used to make slots for this specific stretch


    //Constructor
    public Stretch(int stretchID)
    {
        this.stretchID = stretchID;
        switch (stretchID)
        {
            case 1:
                this.nameOfStartingLocation = "Williamstown";
                this.nameOfEndLocation = "PineCobble";
                this.startingLocationPos = new Vector3(42.716950f,0,0);
                this.endLocationPos = new Vector3(42.726261f,1894,0); 
                this.startingSpot = new Town(nameOfStartingLocation, startingLocationPos, new Vector2(873,266));
                this.endSpot = new Lookout(nameOfEndLocation, endLocationPos, new Vector2(1894,577));
                this.distanceInMiles = 1.5f; //unsure??? 
                this.windingMin = 1.5f;
                this.windingMax = 2.5f;
                this.bumpMin = .5f;
                this.bumpMax = 1f;
                break;
            //Thought: there is "class of 98 trail" between pine cobble and williamstown, i think any protruding paths should be ignored.
            //"This is the path you MUST take the kids down or you'll get in trouble" or something??? But does that make sense if that's the only thing
            //that the camp really cares about? maybe they could also care about money spent in towns.
            case 2:
                this.nameOfStartingLocation = "PineCobble";
                this.nameOfEndLocation = "EphsLookout";
                this.startingLocationPos = new Vector3(42.726261f, 1894,0);
                this.endLocationPos = new Vector3(42.734124f,2280,0);
                startingSpot = new Lookout(nameOfStartingLocation, startingLocationPos, new Vector2(1894, 577));
                endSpot = new Lookout(nameOfEndLocation, endLocationPos, new Vector2(2280, 695)); 
                this.distanceInMiles = 1.2f;
                this.windingMin = .2f;
                this.windingMax = .5f;
                this.bumpMin = .5f;
                this.bumpMax = 1f;
                break;
            case 3:
                this.nameOfStartingLocation = "EphsLookout";
                this.nameOfEndLocation = "SethWarnerShelter";
                this.startingLocationPos = new Vector3(42.734124f, 2280, 0);
                this.endLocationPos = new Vector3(42.771968f ,2300, 0);
                startingSpot = new Lookout(nameOfStartingLocation, startingLocationPos, new Vector2(2280,695));
                endSpot = new Shelter(nameOfEndLocation, endLocationPos, new Vector2(2180, 664)); //converted myself
                this.distanceInMiles = 2.8f;
                this.windingMin = 1f;
                this.windingMax = 1.5f;
                this.bumpMin = .5f;
                this.bumpMax = 1f;
                break;
        }
        this.amountOfSlotsInLevel = (int)(distanceInMiles * 100f);

    }
    //Getters and Setters
    public int AmountOfSlotsInLevel
    {
        get { return amountOfSlotsInLevel; }
        set { amountOfSlotsInLevel = value; }
    }

    public float WindingMin
    {
        get { return windingMin; }
        set { windingMin = value; }
    }
    public float WindingMax
    {
        get { return windingMax; }
        set { windingMax = value; }
    }
    public float BumpMax
    {
        get { return bumpMax; }
        set { bumpMax = value; }
    }
    public float BumpMin
    {
        get { return bumpMin; }
        set { bumpMin = value; }
    }

    public int StretchID
    {
        get { return stretchID; }
        set { stretchID = value; }
    }

    public TrailSpot StartingSpot
    {
        get { return startingSpot; }
        set { startingSpot = value; }
    }
    public TrailSpot EndSpot
    {
        get { return endSpot; }
        set { endSpot = value; }
    }





}