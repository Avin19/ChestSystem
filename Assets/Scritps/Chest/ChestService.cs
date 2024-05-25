using UnityEngine;


public class ChestService
{
    private ChestController chestController;
    private ChestListSO chestListSO;
    private ChestSystemView chestSystemView;
    private GameObject pfItem;
    public ChestService(ChestSystemView _chestSystemView, ChestListSO _chestListSO, GameObject _pfItem)
    {
        this.chestSystemView = _chestSystemView;
        this.chestListSO = _chestListSO;
        this.pfItem = _pfItem;
        chestController = new ChestController(chestSystemView, chestListSO, pfItem);
    }

    public ChestController GetChestController() => chestController;

}