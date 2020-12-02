using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[System.Serializable]
public class HikerGenerator
{
    private List<Hiker> allHikers;
    private List<Camper> campers;
    private List<ThruHiker> otherHikers;
    private List<GameObject> campersPhysical;
    private List<GameObject> otherHikersPhysical;
    private List<GameObject> allHikersPhysical;

    public static int camperCount; //specifically increases when the stats are generated, not the phsyical part
    public static int otherHikerCount;
    public static int allHikerCount;

    public HikerGenerator()
    {
        camperCount = 0;
        otherHikerCount = 0;
        allHikerCount = 0;

        allHikers = new List<Hiker>();
        campers = new List<Camper>();
        otherHikers = new List<ThruHiker>();
        campersPhysical = new List<GameObject>();
        otherHikersPhysical = new List<GameObject>();
        allHikersPhysical = new List<GameObject>();
    }


    public void GenerateCampersInitial(string codeName)
    {
        Camper newCamper = null;
        switch (codeName)
        {
            case "Beth":
                newCamper = new Camper("Beth", 6, 3, 8, 5, 8, 3, 9);
                break;
            case "Dede":
                newCamper = new Camper("Dede", 5, 7, 8, 5, 5, 8, 3);
                break;
            case "Nina":
                newCamper = new Camper("Nina", 9, 7, 6, 5, 6, 5, 5);
                break;
            case "Joan":
                newCamper = new Camper("Joan", 3, 5, 8, 3, 3, 5, 7);
                break;
            case "Marsha": //"Ugh, of COURSE I was made last"
                newCamper = new Camper("Marsha", 6, 8, 4, 8, 6, 4, 2);
                break;
            default:
                Debug.Log("No camper generated.");
                break;
        }
        campers.Add(newCamper);
        allHikers.Add(newCamper);
        Debug.Log("Camper " + newCamper.CodeName + " added to campers at spot " + campers.Count);
        Debug.Log("Camper " + newCamper.CodeName + " added to allHikers at spot " + allHikers.Count);
    }

    public void GenerateCamperTest(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            Camper newCamper = new Camper("Name",10,10,10,10,10,10,10);
            campers.Add(newCamper);
            allHikers.Add(newCamper);
            Debug.Log("Camper " + newCamper.CodeName + " added to campers at spot " + campers.Count);
            Debug.Log("Camper " + newCamper.CodeName + " added to allHikers at spot " + allHikers.Count);
        }
    }

    public void GenerateThruHiker(int amount)
    {  

        for (int i = 0; i < amount; i++)
        {
            ThruHiker newThruHiker = new ThruHiker("Name",10);
            otherHikers.Add(newThruHiker);
            allHikers.Add(newThruHiker);
            Debug.Log("Camper " + newThruHiker.CodeName + " added to otherHikers at spot " + otherHikers.Count);
            Debug.Log("Camper " + newThruHiker.CodeName + " added to allHikers at spot " + allHikers.Count);
        }
    }

    public void CreatePhysicalCamper(SlotGenerator slotGen, GameObject hikerPrefab, int whichSlot)
    {
        GameObject newCamper = GameObject.Instantiate(hikerPrefab, slotGen.slotStorage[whichSlot].FirstPointInSpace + new Vector3(0,1,0),Quaternion.identity);

        campersPhysical.Add(newCamper);
        allHikersPhysical.Add(newCamper);
    }


    public List<Camper> Campers
    {
        get { return campers; }
        set { campers = value; }
    }

    public List<Hiker> AllHikers
    {
        get { return allHikers; }
        set { allHikers = value; }
    }

    public List<ThruHiker> OtherHikers
    {
        get { return otherHikers; }
        set { otherHikers = value; }
    }
}
