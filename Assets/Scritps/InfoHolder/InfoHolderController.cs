using chestSystem;
using UnityEngine;

public class InfoHolderController
{
    private InforHolderView inforHolderView;
    private ChestListSO chestListSO;
    private SOPlayerStatus sOPlayerStatus;
    public InfoHolderController(InforHolderView _inforHolderView, ChestListSO _chestListSO, SOPlayerStatus _soplayerStatus)
    {
        this.inforHolderView = _inforHolderView;
        this.chestListSO = _chestListSO;
        this.sOPlayerStatus = _soplayerStatus;
        SetCoinGem();

    }

    public void SetButtonPanelStatus(bool statusPanel)
    {
        inforHolderView.SetPanelButton(statusPanel);

    }
    private void SetCoinGem()
    {
        inforHolderView.SetGemCoin(sOPlayerStatus.coinAmount, sOPlayerStatus.gemAmount);
    }





}
