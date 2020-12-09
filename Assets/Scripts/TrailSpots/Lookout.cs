using System.Collections;
using UnityEngine;


 public class Lookout : TrailSpot //same function as concept of "mountain peak" or even a cairn hollow. this is what most trail spots are.
 {
    private enum Behaviors
    {
        LookAtView,
        Relax,
        Meeting,
        Lunch
    }
    public Lookout(string spotName, Vector3 spotPosition) : base(spotName, spotPosition)
    {
        spotName = base.SpotName;
        spotPosition = base.SpotPosition;
    }

}
