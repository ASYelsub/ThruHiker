using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ThruHiker is a game about: the weird cult-like expectations of white femininity,
//the real-time experience of growing up, the ethics of recreational nature consumption,
//the ethics of proper rearing, protestantism's infectious impact across north america,
//the trauma and beauty of being outside society

public class GameManager : MonoBehaviour
{
    [Header("Classes Not on Objects")]
    public SlotGenerator slotGenerator;
    public HikerGenerator hikerGenerator;
    public TrailGenerator trailGenerator;
    //public SpaceSlot tempSlot;
    public MovementManager movementManager;
    private CamperOrder camperOrder; //later there will be a screen that's like "pick camper order" & a function thats like "open camper order picker menu"
                                     //maybe it could correspond to UI stuff? //maybe on GameplayUI?
    private Stretch currentStretch;

    [Header("Prefabs")]
    [SerializeField]
    private GameObject slotPrefab;
    [SerializeField]
    private GameObject hikerPrefab;
    [SerializeField]
    private GameObject trailSpotPrefab;

    [Header("Classes")]
    [SerializeField]
    public CamperProfile camperProfile;
    public HolderOfAssets holderOfAssets;

    [Header("In Scene Objects")]
    [SerializeField]
    private GameObject trailHolder;

    void Start()
    {
        //Test();
        trailGenerator = new TrailGenerator();
        /*for(int i = 0; i < trailGenerator.TrailSpots.Count; i++)
        {
            Debug.Log(trailGenerator.TrailSpots[i].SpotName);
        }*/

        slotGenerator = new SlotGenerator();
        hikerGenerator = new HikerGenerator();
        SetGame();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Tab)){
            camperProfile.ToggleProfileDisplay();
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            movementManager.MoveAllCampersForwardOne();
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
        trailGenerator.GenerateTrail(trailGenerator.TrailSpots[0], trailGenerator.TrailSpots[2]);
        currentStretch = trailGenerator.SetCurrentStretch(trailGenerator.AllStretches[0]);
        slotGenerator.GenerateSlotsInCurrentStretch(currentStretch, slotPrefab, trailHolder,holderOfAssets, -6, trailSpotPrefab);
        //programming this as if the "camperOrder" is in according to the default order I've programmed so far
        //guess it's important that they're made in the same order.

        hikerGenerator.GenerateCampersInitial("Beth");
        hikerGenerator.CreatePhysicalCamper(slotGenerator, hikerPrefab, 0);
        hikerGenerator.GenerateCampersInitial("Dede");
        hikerGenerator.CreatePhysicalCamper(slotGenerator, hikerPrefab, 1);
        hikerGenerator.GenerateCampersInitial("Nina");
        hikerGenerator.CreatePhysicalCamper(slotGenerator, hikerPrefab, 2);
        hikerGenerator.GenerateCampersInitial("Joan");
        hikerGenerator.CreatePhysicalCamper(slotGenerator, hikerPrefab, 3);
        hikerGenerator.GenerateCampersInitial("Marsha");
        hikerGenerator.CreatePhysicalCamper(slotGenerator, hikerPrefab, 4);
        
        
        camperOrder = new CamperOrder(hikerGenerator.Campers[0], hikerGenerator.Campers[1], hikerGenerator.Campers[2], hikerGenerator.Campers[3], hikerGenerator.Campers[4]);

        camperProfile.Activate();


        currentStretch = trailGenerator.SetCurrentStretch(trailGenerator.AllStretches[1]);
        slotGenerator.GenerateSlotsInCurrentStretch(currentStretch, slotPrefab, trailHolder, holderOfAssets, 0, trailSpotPrefab);

        currentStretch = trailGenerator.SetCurrentStretch(trailGenerator.AllStretches[2]);
        slotGenerator.GenerateSlotsInCurrentStretch(currentStretch, slotPrefab, trailHolder, holderOfAssets, 6, trailSpotPrefab);
    }

}
