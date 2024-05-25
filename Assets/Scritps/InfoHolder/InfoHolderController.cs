using UnityEngine;

public class InfoHolderController
{
    private InforHolderView inforHolderView;
    public InfoHolderController(InforHolderView _inforHolderView)
    {
        this.inforHolderView = _inforHolderView;
    }

    public void SetButtonPanelStatus(bool statusPanel)
    {
        inforHolderView.SetPanelButton(statusPanel);
    }


}
