using System.Collections;
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
    private Hiker thisHiker;

    [SerializeField]
    private TMP_Text nameDisplay;

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
        thisHiker = gameManager.hikerGenerator.Campers[HikerGenerator.camperCount - 1];
    }

    private void OnMouseEnter()
    {
        this.nameDisplay.text = thisHiker.FirstName;
    }

    private void OnMouseExit()
    {
        this.nameDisplay.text = "";
    }
}
