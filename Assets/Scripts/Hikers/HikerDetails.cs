﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//This is the script that allows you to mouse over a hiker and have its stats show up
//ideally like it also assigns the either thruhiker or camper instantiated classes
//to this game object.
//This also interacts with slots I guess!
public class HikerDetails : MonoBehaviour
{
    public GameManager gameManager;
    private Camper thisHiker;
    private Camera camera;

    [Header("Displays")]
    [SerializeField] private GameObject displayHolder;
    [SerializeField] private TMP_Text nameDisplay;
    [SerializeField] private TMP_Text fatigueDisplay;
    [SerializeField] private TMP_Text happinessDisplay;
    [SerializeField] private TMP_Text hungerDisplay;
    [SerializeField] private TMP_Text restraintDisplay;
    //[SerializeField] private TMP_Text placeInOrderDisplay;

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
        camera = FindObjectOfType<Camera>();
        thisHiker = gameManager.hikerGenerator.Campers[HikerGenerator.camperCount - 1];
        this.nameDisplay.text = "";
        this.fatigueDisplay.text = "";
        this.happinessDisplay.text = "";
        this.hungerDisplay.text = "";
        this.restraintDisplay.text = "";
    }

    private void Update()
    {
        displayHolder.transform.forward = camera.transform.forward;
    }
    private void OnMouseEnter()
    {
        //ideally later these are bars or icons? something more comfortable than numbers.
        this.nameDisplay.text = thisHiker.FirstName;
        this.fatigueDisplay.text = "Fatigue " + thisHiker.CurrentFatigue.ToString();
        this.happinessDisplay.text = "Happiness " + thisHiker.CurrentHappiness.ToString();
        this.hungerDisplay.text = "Hunger " + thisHiker.CurrentHunger.ToString();
        this.restraintDisplay.text = "Restraint " + thisHiker.CurrentRestraint.ToString();
        //this.placeInOrderDisplay.text = thisHiker.CurrentFatigue.ToString();

    }

    private void OnMouseExit()
    {
        this.nameDisplay.text = "";
        this.fatigueDisplay.text = "";
        this.happinessDisplay.text = "";
        this.hungerDisplay.text = "";
        this.restraintDisplay.text = "";
    }
}
