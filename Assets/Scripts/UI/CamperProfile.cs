using System;
using UnityEngine;
using UnityEngine.UI;
//this is the page you pull up that looks like a form that gives you all the information about the kids
//during the journey
//usually this only shows their more "permanant" stats,
//whereas the "flexible" stats appear when you hover over them with the mouse
public class CamperProfile : MonoBehaviour
{
    //helpful website for formatting:
    // https://blog.terresquall.com/2020/07/organising-your-unity-inspector-fields-with-a-dropdown-filter/


    [Header("Archetypes")]
    [SerializeField] private Text ageDisplay;
    [SerializeField] private Text heightDisplay;
    [SerializeField] private Text weightDisplay;
    [SerializeField] private Text birthdayDisplay;


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

    public CamperProfile(string[] inintialBehavior, string[] initialRelationships, string[] initialExpectations)
    {
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
}
