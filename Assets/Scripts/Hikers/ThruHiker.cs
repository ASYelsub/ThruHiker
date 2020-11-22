using System;
public class ThruHiker : Hiker
{
    private String[] dialogue;
    private float happinessChange;

    public ThruHiker(string codeName, SpaceSlot currentSlot, float currentSpeed)
         : base(codeName, currentSlot, currentSpeed)
    {
    }
}
