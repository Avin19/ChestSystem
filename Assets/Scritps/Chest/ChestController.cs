using UnityEngine;

public class ChestController
{
    private ChestSystemView chestSystemView;
    private ChestListSO chestListSO;
    private GameObject pfITem;

    public ChestController(ChestSystemView _chestSystemView, ChestListSO _chestListSO, GameObject _pfitem)
    {
        this.chestListSO = _chestListSO;
        this.chestSystemView = _chestSystemView;
        this.pfITem = _pfitem;
        SettingUpChest();
    }

    private void SettingUpChest()
    {
        foreach (ChestInfoSO chest in chestListSO.ChestInfoSOList)
        {
            ChestItem item = GameObject.Instantiate(pfITem, chestSystemView.transform).GetComponent<ChestItem>();
            item.SetImage(chest.chestImage);
            // item.GetName(chest.chestName);
            item.SetTime(chest.lockedTime);
            item.GetChestInfoSO(chest);

        }
    }

}
