using System;
using UnityEngine;
using UnityEngine.UI;

public class CutScene
{
    //Displaying in Unity
    [SerializeField] private Text displayText;

    private String[] textInCutScene;


    private Hiker speakingHiker; //can be a camper or a hiker

    public CutScene()
    {
    }
}
