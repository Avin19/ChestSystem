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
    public void UpdateGem(int _gemUsed)
    {
        sOPlayerStatus.gemAmount -= _gemUsed;
        SetCoinGem();

    }
    public void CollectReward(int _rewardCoin, int _rewardGem)
    {
        sOPlayerStatus.coinAmount += _rewardCoin;
        sOPlayerStatus.gemAmount += _rewardGem;
    }






}
