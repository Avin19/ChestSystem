using UnityEngine;


public class ChestService
{
    private ChestController chestController;
    private ChestListSO chestListSO;
    private ChestSystemView chestSystemView;
    public ChestService(ChestSystemView _chestSystemView, ChestListSO _chestListSO)
    {
        this.chestSystemView = _chestSystemView;
        this.chestListSO = _chestListSO;
        chestController = new ChestController(chestSystemView, chestListSO);
    }

    public ChestController GetChestController() => chestController;

}