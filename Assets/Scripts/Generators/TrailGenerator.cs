using System;
using System.Collections.Generic;
using UnityEngine;

//the "trail" is the conglomeration of "stretches" or whatever
//this script is called from gameManager and integrates all the trailSpots and stretches (hold parameters to create a bunch of slots)
public class TrailGenerator : MonoBehaviour
{
    private List<Stretch> allStretches;
    private List<TrailSpot> trailSpots;

    private TrailSpot firstLocation;
    private TrailSpot finalLocation;

    private Stretch currentStretch;
    public TrailGenerator()
    {
        allStretches = new List<Stretch>();
        trailSpots = new List<TrailSpot>();
        allStretches.Add(new Stretch(1));
        trailSpots.Add(AllStretches[0].StartingSpot);
        allStretches.Add(new Stretch(2));
        trailSpots.Add(AllStretches[1].StartingSpot);
        allStretches.Add(new Stretch(3));
        trailSpots.Add(AllStretches[2].StartingSpot);
        trailSpots.Add(AllStretches[2].EndSpot);
    }

    public void GenerateTrail(TrailSpot first, TrailSpot final)
    {
        this.firstLocation = first;
        this.finalLocation = final;

        
        
        /*Debug.Log("Trail Generated!");
        Debug.Log("First location: " + firstLocation.SpotName);
        Debug.Log("Final location: " + finalLocation.SpotName);*/
    }

    public Stretch SetCurrentStretch(Stretch inputStretch)
    {
        currentStretch = inputStretch;
        Debug.Log("Current stretch set to: " + 
            currentStretch.StartingSpot.SpotName + " / " + currentStretch.EndSpot.SpotName);
        return inputStretch;
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
