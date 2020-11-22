using System;
public class Camper : Hiker
{
    private int age;
    private int height;
    private int weight;

    private float currentFatigue;
    private float currentHappiness;
    private float currentHunger;
    private float currentRestraint;

    private float endurance; //how much they can walk without stopping affects their fatigue
    private float socialSensitivity; //how much weird things on trail impact their happiness
    private float strength; //how much they can carry on their back affects their fatigue
    private float appetite; //if this is higher their hunger decreases quicker
    private float selfControl; //how much fatigue and hunger affect their restraint


    private int socialStanding; //where they are in popularity
    private int placeInLineup;

    public Camper(string codeName, SpaceSlot currentSlot, float currentSpeed,
        float endurance, float socialSensitivity, float strength, float appetite, float selfControl)
        : base(codeName, currentSlot, currentSpeed)
    {
        base.CodeName = codeName;
        base.CurrentSlot = currentSlot;
        base.CurrentSpeed = CurrentSpeed;


        //100 is max, 0 is min. Closer to 0 the worse.
        //All campers when first created may not be at 100 to start,
        //depends on what i want their initial moods to be.
        //might have an if statement dependent on name
        this.currentFatigue = 100;
        this.currentHappiness = 100;
        this.currentHunger = 100;
        this.currentRestraint = 100;

        this.endurance = endurance;
        this.socialSensitivity = socialSensitivity;
        this.strength = strength;
        this.appetite = appetite;
        this.selfControl = selfControl;

    }

    public void increaseCoreStat(string coreStat, float increaseAmount)
    { 

        switch (coreStat)
        {
            case "endurance":
                this.endurance = this.endurance + increaseAmount;
                break;
            case "socialSensitivity":
                this.socialSensitivity = this.socialSensitivity + increaseAmount;
                break;
            case "strength":
                this.strength = this.strength + increaseAmount;
                break;
            case "appetite":
                this.appetite = this.appetite + increaseAmount;
                break;
            case "selfControl":
                this.selfControl = this.selfControl + increaseAmount;
                break;
            default:
                Console.WriteLine("Default case");
                break;
        }
        
    }




    //Getters and setters specific to campers
    //These are stats that don't change unless they
    //"level them up" for some reason... maybe at the end of the day?
    public float Endurance
    {
        get { return endurance; }
        set { endurance = value; }
    }
    public float SocialSensitivity
    {
        get { return socialSensitivity; }
        set { socialSensitivity = value; }
    }
    public float Strength
    {
        get { return strength; }
        set { strength = value; }
    }
    public float Appetite
    {
        get { return appetite; }
        set { appetite = value; }
    }
    public float SelfControl
    {
        get { return selfControl; }
        set { selfControl = value; }
    }


}
