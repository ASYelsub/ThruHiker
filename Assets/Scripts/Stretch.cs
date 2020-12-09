using System;
using System.Collections.Generic;
using UnityEngine;

public class Stretch
{
    
    private string stretchID; //QUESTION: Should every day be another level? Can the player take days off? How much of the work can the player plan vs how much
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

    private int amountOfSLotsInLevel;
    private float steepnessMax; //the biggest difference two slots can be from one another on the y
    private float steepnessMin;
    private float windingMax; //same as steepness but for x
    private float windingMin;


    private List<SpaceSlot> specificSlotAdvent; //if i want to program in like a bunch of cairn slots near one another or like a really steep mountain
    private bool isSpecific; //if an advent of slots is random or specific
    private List<SpaceSlot> allSlotsInStretch; //corresponds to amountOfSlots

    private List<ThruHiker> otherHikersInStretch; //all of the other thru hikers
    private List<ThruHiker> specificHikersInStretch; //thru hikers that have non-generic interactions w player/campers

    public SlotGenerator slotGenerator;
    //used to make slots for this specific stretch


    //Constructor
    public Stretch(string stretchID)
    {
        this.stretchID = stretchID;
        switch (stretchID)
        {
            case "Stretch1":
                this.nameOfStartingLocation = "Williamstown";
                this.nameOfEndLocation = "PineCobble";
                this.startingLocationPos = new Vector3(42.716950f,0,-73.184321f);
                this.endLocationPos = new Vector3(42.726261f,1894,-73.161012f); //unsure how to measure altitude just yet... ugh
                this.startingSpot = new Town(nameOfStartingLocation, startingLocationPos);
                this.endSpot = new Lookout(nameOfEndLocation, endLocationPos);
                this.distanceInMiles = 2.1f;
                break;
            //Thought: there is "class of 98 trail" between pine cobble and williamstown, i think any protruding paths should be ignored.
            //"This is the path you MUST take the kids down or you'll get in trouble" or something??? But does that make sense if that's the only thing
            //that the camp really cares about? maybe they could also care about money spent in towns.
            case "Stretch2":
                this.nameOfStartingLocation = "PineCobble";
                this.nameOfEndLocation = "EphsLookout";
                this.startingLocationPos = new Vector3(42.726261f, 1894, -73.161012f);
                this.endLocationPos = new Vector3(42.734124f,2280,-73.158174f);
                startingSpot = new Lookout(nameOfStartingLocation, startingLocationPos);
                endSpot = new Lookout(nameOfEndLocation, endLocationPos);
                this.distanceInMiles = 1.2f;
                break;
            case "Stretch3":
                this.nameOfStartingLocation = "EphsLookout";
                this.nameOfEndLocation = "SethWarnerShelter";
                this.startingLocationPos = new Vector3(42.734124f, 2280, -73.158174f);
                this.endLocationPos = new Vector3(42.771968f ,2300, -73.136644f);
                startingSpot = new Lookout(nameOfStartingLocation, startingLocationPos);
                endSpot = new Shelter(nameOfEndLocation, endLocationPos);
                this.distanceInMiles = 2.8f;
                break;
        }
        
    }
    //Getters and Setters
    public string StretchID
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