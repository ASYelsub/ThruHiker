using System.Collections;
using UnityEngine;


public  class StatManager
{
    private int money;
    private int time;
    private int campStatus;
    private int food;


    public int Money
    {
        get { return money; }
        set { money = value; }
    }
    public int Time
    {
        get { return time; }
        set { time = value; }
    }
    public int CampStatus
    {
        get { return campStatus; }
        set { campStatus = value; }
    }
    public int Food
    {
        get { return food; }
        set { food = value; }
    }

}
