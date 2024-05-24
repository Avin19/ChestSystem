using UnityEngine;

public class ChestController
{
    private ChestSystemView chestSystemView;
    private ChestListSO chestListSO;

    public ChestController(ChestSystemView chestSystemView, ChestListSO chestListSO)
    {
        this.chestListSO = chestListSO;
        this.chestSystemView = chestSystemView;
    }

}
