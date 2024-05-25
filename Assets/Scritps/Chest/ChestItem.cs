using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class ChestItem : MonoBehaviour
{
    [SerializeField] private Sprite iconSprite;
    [SerializeField] private TextMeshProUGUI textTimer;
    [SerializeField] private TextMeshProUGUI chestName;
    [SerializeField] private Button onButton;
    private ChestInfoSO chestInfoSO;
    private bool startUnloacked = false;

    public void SetImage(Sprite _image) => iconSprite = _image;
    public void GetName(string _chestName) => chestName.text = _chestName;
    public void GetChestInfoSO(ChestInfoSO _chestInfoSO) => chestInfoSO = _chestInfoSO;

    private void OnEnable()
    {
        onButton.onClick.AddListener(OnButtonClick);
    }
    private void OnDisable()
    {
        onButton.onClick.RemoveListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        GameService.Instance.SetChestItem(this);
        GameService.Instance.GetInfoHolderService().GetInfoHolderController().SetButtonPanelStatus(true);
    }

    public void SetTime(float _time)
    {
        textTimer.text = _time.ToString();
    }
    public void SetBoolTimer(bool _unlocked) => startUnloacked = _unlocked;
    private void Update()
    {
        if (startUnloacked)
        {
            StartTimer();
        }
    }

    private void StartTimer()
    {
        chestInfoSO.unlockTimer -= Time.deltaTime;
        textTimer.text = (chestInfoSO.unlockTimer).ToString();
    }
}
