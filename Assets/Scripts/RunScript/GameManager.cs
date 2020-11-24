using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ThruHiker is a game about: the weird cult-like expectations of white femininity,
//the real-time experience of growing up, the ethics of recreational nature consumption,
//the ethics of proper rearing, protestantism's infectious impact across north america,
//the trauma and beauty of being outside society

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
