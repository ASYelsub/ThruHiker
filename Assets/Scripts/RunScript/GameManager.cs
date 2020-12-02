using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ThruHiker is a game about: the weird cult-like expectations of white femininity,
//the real-time experience of growing up, the ethics of recreational nature consumption,
//the ethics of proper rearing, protestantism's infectious impact across north america,
//the trauma and beauty of being outside society

public class GameManager : MonoBehaviour
{
    public SlotGenerator slotGenerator;
    public HikerGenerator hikerGenerator;

    [Header("Prefabs")]
    [SerializeField]
    private GameObject slotPrefab;
    [SerializeField]
    private GameObject hikerPrefab;

    [Header("Classes")]
    [SerializeField]
    private CamperProfile camperProfile;

    [Header("In Scene Objects")]
    [SerializeField]
    private GameObject trailHolder;

    public SpaceSlot tempSlot;

    void Start()
    {
        //Test();
        slotGenerator = new SlotGenerator();
        hikerGenerator = new HikerGenerator();
        SetGame();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            camperProfile.ToggleProfileDisplay();
        }
    }

    void Test()
    {
        //slotGenerator = new SlotGenerator();
        //slotGenerator.GenerateRandomSlots(10);
        //hikerGenerator = new HikerGenerator();
        //hikerGenerator.GenerateCamperTest(5);
        //hikerGenerator.GenerateThruHiker(5);
    }

    void SetGame()
    {
        slotGenerator.GenerateRandomSlots(10, slotPrefab, trailHolder);
        //programming this as if the "camperOrder" is in according to the default order I've programmed so far

        //	slotGenerator	The identifier `slotGenerator` is not in the scope	// wtf does this mean???
        //hikerGenerator.GenerateCamperTest(1, tempSlot, hikerPrefab);
        hikerGenerator.GenerateCampersInitial("Beth");
        hikerGenerator.GenerateCampersInitial("Dede");
        hikerGenerator.GenerateCampersInitial("Nina");
        hikerGenerator.GenerateCampersInitial("Joan");
        hikerGenerator.GenerateCampersInitial("Marsha");
        camperProfile.Activate();

        hikerGenerator.Campers[0].CreatePhysicalHiker(slotGenerator, hikerPrefab);
    }

}
