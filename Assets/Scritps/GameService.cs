using chestSystem;
using UnityEngine;

public class GameService : GenericMonoSingleton<GameService>
{
    [Header("Service")]
    [SerializeField] private ChestService chestService;
    [SerializeField] private InfoHolderService infoHolderService;

    [Header("View")]
    [SerializeField] private ChestSystemView chestSystemView;
    [SerializeField] private InforHolderView inforHolderView;

    [Header(" Perfabs ")]
    [SerializeField] private GameObject pfItem;

    [Header(" ScriptableObject ")]
    [SerializeField] private ChestListSO chestListSO;
    [SerializeField] private SOPlayerStatus sOPlayerStatus;
    private ChestInfoSO chestInfoSO;
    private ChestItem chestItem;

    private void Start()
    {
        chestService = new ChestService(chestSystemView, chestListSO, pfItem);
        infoHolderService = new InfoHolderService(inforHolderView, chestListSO, sOPlayerStatus);


    }

    #region Getter

    public ChestService GetChestService() => chestService;
    public InfoHolderService GetInfoHolderService() => infoHolderService;
    public ChestInfoSO GetChestInfo() => chestInfoSO;
    public void SetChestItem(ChestItem _chestitem) => chestItem = _chestitem;
    public ChestItem GetChestItem() => chestItem;

    #endregion

}
