using System.Collections;
using UnityEngine;

public class TrailSpotBehaviors
{
   /* private StatManager statManager;

    public TrailSpotBehaviors(StatManager statManager)
    {
        this.statManager = statManager;
    }*/
public interface IRestock
{
    void Restock();
}

interface IRelax
{
    void Relax();
}

interface IMeeting
{
    void Meeting();
}

interface ILunch
{
    void Lunch();
}

interface IRefillWater
{
    void RefillWater();
}

interface IBathe
{
    void Bathe();
}

interface ICamp
{
    void Camp();
}

interface ILookAtView
{
    void LookAtView();
}
}





