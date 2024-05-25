using UnityEngine;


public class InfoHolderService
{
    private InforHolderView inforHolderView;
    private InfoHolderController infoHolderController;
    public InfoHolderService(InforHolderView _inforHolderView)
    {
        this.inforHolderView = _inforHolderView;
        infoHolderController = new InfoHolderController(inforHolderView);

    }
    public InfoHolderController GetInfoHolderController() => infoHolderController;
}