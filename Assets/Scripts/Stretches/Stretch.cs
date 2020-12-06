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

    private string nameOfStartingLocation; //for day one it's Williamstown
    private string nameOfEndLocation; //for day one its Seth Warner Shelter


    private int amountOfSLotsInLevel;
    private float steepnessMax; //the biggest difference two slots can be from one another on the y
    private float steepnessMin;
    private float windingMax; //same as steepness but for x
    private float windingMin;


    private List<SpaceSlot> specificSlotAdvent; //if i want to program in like a bunch of cairn slots near one another or like a really steep mountain
    private bool isSpecific; //if an advent of slots is random or specific
    private List<SpaceSlot> allSlotsInLevel; //corresponds to amountOfSlots

    private List<ThruHiker> otherHikersInLevel; //all of the other thru hikers
    private List<ThruHiker> specificHikersInLevel; //thru hikers that have non-generic interactions w player/campers


    //Constructor
    public Stretch(string stretch)
    {
        this.stretchID = stretchID;
        switch (stretchID)
        {
            case "FirstStretch":
                break;
        }
    }


    //Getters and Setters
    public string StretchID
    {
        get { return stretchID; }
        set { stretchID = value; }
    }





}