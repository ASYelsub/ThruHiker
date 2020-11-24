using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
//this is the page you pull up that looks like a form that gives you all the information about the kids
//during the journey
//usually this only shows their more "permanant" stats,
//whereas the "flexible" stats appear when you hover over them with the mouse
public class CamperProfile : MonoBehaviour
{
    //helpful website for formatting:
    // https://blog.terresquall.com/2020/07/organising-your-unity-inspector-fields-with-a-dropdown-filter/

    [Header("Classes")]
    public GameManager gameManager;
    private List<Camper> campers;

    [Header("Parent Object")]
    [SerializeField] private GameObject camperProfileHolder;
    private bool camperProfileVisible;

    [Header("Archetypes")]
    [SerializeField] private Text nameDisplay;
    [SerializeField] private Text ageDisplay;
    [SerializeField] private Text birthdayDisplay;
    [SerializeField] private Text heightDisplay;
    [SerializeField] private Text weightDisplay;
    
    [Header("Solid Stats")]
    [SerializeField] private Text enduranceDisplay;
    [SerializeField] private Text socialSensitivityDisplay;
    [SerializeField] private Text strengthDisplay;
    [SerializeField] private Text appetiteDisplay;
    [SerializeField] private Text selfControlDisplay;
    [SerializeField] private Text weirdnessDisplay;

    [Header("Written Descriptions")]
    [SerializeField] private Text initialBehaviors;
    [SerializeField] private Text accumulatedBehaviors;
    [SerializeField] private Text initialRelationships;
    [SerializeField] private Text accumulatedRelationships;
    [SerializeField] private Text initialExpectations;
    [SerializeField] private Text accumulatedExpectations;

    [Header("Visuals")]
    [SerializeField] private Image camperPic;

    
    public void Start()
    {
        this.camperProfileVisible = false;
        camperProfileHolder.SetActive(false);
        for(int i = 0; i < gameManager.hikerGenerator.Campers.Count; i++)
        {
            this.campers.Add(gameManager.hikerGenerator.Campers[i]);
        }
        ChangeToCamper(1);
    }

    public void SetSolidStats(int endurance, int socialSensitivity, int strength,
        int appetite, int selfControl, int weirdness)
    {
        this.enduranceDisplay.text = endurance.ToString();
        this.socialSensitivityDisplay.text = socialSensitivity.ToString();
        this.strengthDisplay.text = strength.ToString();
        this.appetiteDisplay.text = appetite.ToString();
        this.selfControlDisplay.text = selfControl.ToString();
        this.weirdnessDisplay.text = weirdness.ToString();
    }

    public void ToggleProfileDisplay()
    {
        //Debug.Log("THIS FUNCTION WAS CALLED");
        if (camperProfileVisible)
            camperProfileHolder.SetActive(false);
        else
            camperProfileHolder.SetActive(true);

        this.camperProfileVisible = !camperProfileVisible;

    }

    public void ChangeToCamper(int camperID)
    {
        this.nameDisplay.text = this.campers[camperID].FirstName + " " + this.campers[camperID].LastName;
        this.ageDisplay.text = this.campers[camperID].Age.ToString();
        this.birthdayDisplay.text = this.campers[camperID].BirthdayMonth + "/" + this.campers[camperID].BirthdayDayOfMonth.ToString();
        this.heightDisplay.text = this.campers[camperID].Height.ToString();
        this.weightDisplay.text = this.campers[camperID].Weight.ToString();

        this.enduranceDisplay.text = this.campers[camperID].Endurance.ToString();
        this.socialSensitivityDisplay.text = this.campers[camperID].SocialSensitivity.ToString();
        this.strengthDisplay.text = this.campers[camperID].SocialSensitivity.ToString();
        this.appetiteDisplay.text = this.campers[camperID].SocialSensitivity.ToString();
        this.selfControlDisplay.text = this.campers[camperID].SocialSensitivity.ToString();
        this.weirdnessDisplay.text = this.campers[camperID].SocialSensitivity.ToString();
    }
}
