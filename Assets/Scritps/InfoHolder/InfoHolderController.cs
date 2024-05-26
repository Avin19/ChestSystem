using UnityEngine;

public class InfoHolderController
{
    private InforHolderView inforHolderView;
    private ChestListSO chestListSO;
    public InfoHolderController(InforHolderView _inforHolderView, ChestListSO _chestListSO)
    {
        this.inforHolderView = _inforHolderView;
        this.chestListSO = _chestListSO;
    }

    public void SetButtonPanelStatus(bool statusPanel)
    {
        inforHolderView.SetPanelButton(statusPanel);
    }

    public void OnGenerateButtonClick()
    {

    }
}
