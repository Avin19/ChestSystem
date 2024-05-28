using System;
using chestSystem;
using UnityEngine;

public class InfoHolderService
{
    private InfoHolderController infoHolderController;

    public InfoHolderService(InforHolderView _inforHolderView, ChestListSO _chestListSO, SOPlayerStatus _soplayerStatus)
    {

        infoHolderController = new InfoHolderController(_inforHolderView, _chestListSO, _soplayerStatus);


    }
    public InfoHolderController GetInfoHolderController() => infoHolderController;




}