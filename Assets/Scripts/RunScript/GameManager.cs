using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private SlotGenerator slotGenerator;
    private HikerGenerator hikerGenerator;

    void Start()
    {
        //Test();
        SetGame();
    }

    void Test()
    {
        slotGenerator = new SlotGenerator();
        slotGenerator.GenerateRandomSlots(10);
        hikerGenerator = new HikerGenerator();
        //hikerGenerator.GenerateCamperTest(5);
        hikerGenerator.GenerateThruHiker(5);
    }

    void SetGame()
    {
        hikerGenerator = new HikerGenerator();
        hikerGenerator.GenerateCampersInitial("Beth");
        hikerGenerator.GenerateCampersInitial("Dede");
        hikerGenerator.GenerateCampersInitial("Nina");
        hikerGenerator.GenerateCampersInitial("Joan");
        hikerGenerator.GenerateCampersInitial("Marsha");
    }

}
