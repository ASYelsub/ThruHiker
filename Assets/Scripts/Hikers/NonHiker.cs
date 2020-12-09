using System;
using System.Collections.Generic;
using UnityEngine;


public class NonHiker
{
    private string firstName;
    private string lastName;
    private string codeName;

    private string[] dialogue;

    public enum NonHikerType
    {
        Vendor,
        Ranger,
        Caretaker,
        Woodsperson
    }

    private NonHikerType nonHikerType;
    public NonHiker(string codeName, NonHikerType nonHikerType)
    {
        this.codeName = codeName;
        this.nonHikerType = nonHikerType;
    }
}
