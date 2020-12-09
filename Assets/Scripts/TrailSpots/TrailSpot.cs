using UnityEditor;
using UnityEngine;

//Oof. Okay so this is like "shelter" or "lookout" or "town." You can stop at these places and change stats. Every night you and campers
//should make it to "shelter" or like "camp karma" gets docked or something and you lose money??? to spend on food? That sounds dumb tho :P

//probably has specific NPC's also at each spot?
//i guess some of the thru hikers could turn into NPCs.
public abstract class TrailSpot : TrailSpotBehaviors
{
    private string spotName;
    private Vector3 spotPosition;

    public enum SpotTypes
    {
        Shelter,
        Lookout,
        Town,
        Lake,
        River
    }

    private SpotTypes spotType;

    public TrailSpot(string spotName, Vector3 spotPosition)
    {
        this.spotPosition = spotPosition;
        this.spotName = spotName;
    }

    public string SpotName
    {
        get { return spotName; }
        set { spotName = value; }
    }

    public SpotTypes SpotType
    {
        get { return spotType; }
        set { spotType = value; }
    }

    public Vector3 SpotPosition
    {
        get { return spotPosition; }
        set { spotPosition = value; }
    }


}
