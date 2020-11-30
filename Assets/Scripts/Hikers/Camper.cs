using System;
using UnityEngine;
public class Camper : Hiker
{
    public enum CamperCodeNames
    {
        Beth, //Beth Sharks?
        Dede, //Desiree Dreary
        Nina, //Nina Locklear
        Joan, //Joan ?
        Marhsa //Marsha ?
    }

    [Header("Archetypes")] //a brief visual
    private int age;
    private int height;
    private int weight;
    private string birthdayMonth;
    private int birthdayDayOfMonth;

    [Header("Flexible Stats")]
    private float currentFatigue;
    private float currentHappiness;
    private float currentHunger;
    private float currentRestraint;

    [Header("Solid Stats")]
    private float endurance; //how much they can walk without stopping affects their fatigue
    private float socialSensitivity; //how much weird things on trail impact their happiness
    private float strength; //how much they can carry on their back affects their fatigue
    private float appetite; //if this is higher their hunger decreases quicker
    private float selfControl; //how much fatigue and hunger affect their restraint,
                                    //also negative how much they are an ass to u :P
    private float weirdness; //???? how weird they are??? honestly this might have 0 mechanical impact
                                //but just mentally help me for characterization between dede and joan

    [Header("Daily Inputs")]
    private int socialStanding; //where they are in popularity
    private int placeInLineup;


    [Header("Written Descriptions")]
    private string initialBehaviors;
    private string[] accumulatedBehaviors;
    private string initialRelationships;
    private string[] accumulatedRelationships;
    private string initialExpectations;
    private string[] accumulatedExpectations;

    public Camper(string codeName, float currentSpeed,
        float endurance, float socialSensitivity, float strength, float appetite, float selfControl, float weirdness)
        : base(codeName, currentSpeed)
    {
        base.CodeName = codeName;
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
        this.weirdness = weirdness;

        switch (codeName)
        {
            case "Beth":
                base.FirstName = "Beth";
                base.LastName = "Sharks";
                this.age = 11;
                this.height = 58;
                this.weight = 110;
                this.birthdayMonth = "Feb";
                this.birthdayDayOfMonth = 1;
                this.socialStanding = 5;
                this.initialBehaviors = "Beth something behavior";
                this.initialRelationships = "Vibes with someone";
                this.initialExpectations = "BRUH";
                break;
            case "Dede":
                base.FirstName = "Desiree";
                base.LastName = "Dreary";
                this.age = 11;
                this.height = 54;
                this.weight = 88;
                this.birthdayMonth = "Mar";
                this.birthdayDayOfMonth = 10;
                this.socialStanding = 4;
                this.initialBehaviors = "Beth something behavior";
                this.initialRelationships = "Vibes with someone";
                this.initialExpectations = "BRUH";
                break;
            case "Nina":
                base.FirstName = "Nina";
                base.LastName = "Locklear";
                this.age = 12;
                this.height = 63;
                this.weight = 110;
                this.birthdayMonth = "Oct";
                this.birthdayDayOfMonth = 4;
                this.socialStanding = 2;
                this.initialBehaviors = "Beth something behavior";
                this.initialRelationships = "Vibes with someone";
                this.initialExpectations = "BRUH";
                break;
            case "Joan":
                base.FirstName = "Joan";
                base.LastName = "";
                this.age = 12;
                this.height = 51;
                this.weight = 80;
                this.birthdayMonth = "Dec";
                this.birthdayDayOfMonth = 19;
                this.socialStanding = 3;
                this.initialBehaviors = "Beth something behavior";
                this.initialRelationships = "Vibes with someone";
                this.initialExpectations = "BRUH";
                break;
            case "Marsha":
                base.FirstName = "Marsha";
                base.LastName = "";
                this.age = 12;
                this.height = 57;
                this.weight = 98;
                this.birthdayMonth = "May";
                this.birthdayDayOfMonth = 25;
                this.socialStanding = 1;
                this.initialBehaviors = "Beth something behavior";
                this.initialRelationships = "Vibes with someone";
                this.initialExpectations = "BRUH";
                break;
        }
    }

    //arbitrary characterization stats
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    public int Height
    {
        get { return height; }
        set { height = value; }
    }
    public int Weight
    {
        get { return weight; }
        set { weight = value; }
    }
    public string BirthdayMonth
    {
        get { return birthdayMonth; }
        set { birthdayMonth = value; }
    }
    public int BirthdayDayOfMonth
    {
        get { return birthdayDayOfMonth; }
        set { birthdayDayOfMonth = value; }
    }


    //Text in camper profile
    public string InitialBehaviors
    {
        get { return initialBehaviors; }
        set { initialBehaviors = value; }
    }
    public string InitialRelationships
    {
        get { return initialRelationships; }
        set { initialRelationships = value; }
    }
    public string InitialExpectations
    {
        get { return initialExpectations; }
        set { initialExpectations = value; }
    }


    //Stats that change depending on the journey
    public float CurrentFatigue
    {
        get { return currentFatigue; }
        set { currentFatigue = value; }
    }
    public float CurrentHappiness
    {
        get { return currentHappiness; }
        set { currentHappiness = value; }
    }
    public float CurrentHunger
    {
        get { return currentHunger; }
        set { currentHunger = value; }
    }
    public float CurrentRestraint
    {
        get { return currentRestraint; }
        set { CurrentRestraint = value; }
    }
    public int SocialStanding
    {
        get { return socialStanding; }
        set { socialStanding = value; }
    }
    public int PlaceInLineup
    {
        get { return placeInLineup; }
        set { placeInLineup = value; }
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
    public float Weirdness
    {
        get { return weirdness; }
        set { weirdness = value; }
    }


    
}
