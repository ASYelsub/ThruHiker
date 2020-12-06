using System.Collections;
using System.Collections.Generic;
using System;

//A new one of these is made every day, or maybe it's overwritten.
//Input is handled/decided by player depending on power dynamics
//currently seen in kids
public class CamperOrder
{
    private Camper leader;
    private Camper secondInLine;
    private Camper thirdInLine;
    private Camper fourthInLine;
    private Camper finalCamper;

    private List<Camper> campersInOrder;

    public CamperOrder(Camper leader, Camper secondInLine, Camper thirdInLine, Camper fourthInLine, Camper finalCamper)
    {
        this.leader = leader;
        this.secondInLine = secondInLine;
        this.thirdInLine = thirdInLine;
        this.fourthInLine = fourthInLine;
        this.finalCamper = finalCamper;
        //Maybe this could be a queue or a stack or something? something about interacting w them in line. But idk if i want that specificity.
        campersInOrder = new List<Camper>();
        campersInOrder.Add(leader);
        campersInOrder.Add(secondInLine);
        campersInOrder.Add(thirdInLine);
        campersInOrder.Add(fourthInLine);
        campersInOrder.Add(finalCamper);
    }

    public Camper Leader
    {
        get { return leader; }
        set { leader = value; }
    }
    public Camper SecondInLine
    {
        get { return secondInLine; }
        set { secondInLine = value; }
    }
    public Camper ThirdInLine
    {
        get { return thirdInLine; }
        set { thirdInLine = value; }
    }
    public Camper FourthInLine
    {
        get { return fourthInLine; }
        set { fourthInLine = value; }
    }
    public Camper FinalCamper
    {
        get { return finalCamper; }
        set { finalCamper = value; }
    }
}
