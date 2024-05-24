using UnityEngine;

public class GameService : GenericMonoSingleton<GameService>
{
    [Header("Service")]
    [SerializeField] private ChestService chestService;
    [SerializeField] private InfoHolderService infoHolderService;

    [Header(" View")]
    [SerializeField] private ChestSystemView chestSystemView;
    [SerializeField] private InforHolderView inforHolderView;


    [Header(" ScriptableObject")]
    [SerializeField] private ChestListSO chestListSO;




    private void Start()
    {
        chestService = new ChestService(chestSystemView, chestListSO);
        infoHolderService = new InfoHolderService(inforHolderView);

    }

}
