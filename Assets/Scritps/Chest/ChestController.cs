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
        // SettingUpChest();
    }

    public void SettingUpChest()
    {

        for (int i = 0; i <= 4; i++)
        {
            ChestInfoSO chest = chestListSO.ChestInfoSOList[Random.Range(0, chestListSO.ChestInfoSOList.Count)];
            ChestItem item = GameObject.Instantiate(pfITem, chestSystemView.transform).GetComponent<ChestItem>();
            item.SetImage(chest.chestImage);
            item.SetTime(chest.lockedTime);
            item.GetChestInfoSO(chest);

        }

    }

}
