using System;
using System.Collections.Generic;
using UnityEngine;

//This script saves a bunch of variables that the player needs to access when re-loading the game.
public class SaveData
{

    //Saves all the camper data here.
    private Camper Beth;
    private Camper Nina;
    private Camper Marsha;
    private Camper Joan;
    private Camper Dede;


    private TrailSpot currentTrailSpot; //player can only save at TrailSpots

    private int moneyAmount;
    private int campKarmaAmount;
    private int deathCount; //How many of the kids died??? Obv gonna remove this but what should like a "you fucked up" counter be? Will there even be such a thing?
                            //I guess the "you fucked up" comes from whatever happens along the journey.

    //Are these the only things keeping track of progress? BC the shit in here changes def.
    private List<CamperProfile> camperProfiles;
    private List<CamperLetter> camperLetters;

}
