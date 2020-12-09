using System;
using System.Collections.Generic;
using UnityEngine;

//the "trail" is the conglomeration of "stretches" or whatever
//this script is called from gameManager and integrates all the trailSpots and stretches (hold parameters to create a bunch of slots)
public class TrailGenerator
{
    private List<Stretch> allStretches;
    private List<TrailSpot> trailSpots;

    private TrailSpot firstLocation;
    private TrailSpot finalLocation;
    public TrailGenerator()
    {

        allStretches.Add(new Stretch("Strech1"));
        trailSpots.Add(AllStretches[0].StartingSpot);
        allStretches.Add(new Stretch("Strech2"));
        trailSpots.Add(AllStretches[1].StartingSpot);
        allStretches.Add(new Stretch("Strech3"));
        trailSpots.Add(AllStretches[2].StartingSpot);
        trailSpots.Add(AllStretches[2].EndSpot);
    }

    public void GenerateTrail(TrailSpot firstLocation, TrailSpot finalLocation)
    {
        this.firstLocation = firstLocation;
        this.finalLocation = finalLocation;
    }


    public List<Stretch> AllStretches
    {
        get { return allStretches; }
        set { allStretches = value; }
    }
    public List<TrailSpot> TrailSpots
    {
        get { return trailSpots; }
        set { trailSpots = value; }
    }
    public TrailSpot FirstLocation
    {
        get { return firstLocation; }
        set { firstLocation = value; }
    }
    public TrailSpot FinalLocation
    {
        get { return finalLocation; }
        set { finalLocation = value; }
    }
}
