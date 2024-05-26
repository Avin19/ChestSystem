using UnityEngine;

public class InfoHolderService
{
    private InforHolderView inforHolderView;
    private InfoHolderController infoHolderController;
    private ChestListSO chestListSO;
    public InfoHolderService(InforHolderView _inforHolderView, ChestListSO _chestListSO)
    {
        this.inforHolderView = _inforHolderView;
        this.chestListSO = _chestListSO;
        infoHolderController = new InfoHolderController(inforHolderView, chestListSO);

    }
    public InfoHolderController GetInfoHolderController() => infoHolderController;


}