using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;


public class ChestItem : MonoBehaviour
{
    [SerializeField] private Image iconSprite;
    [SerializeField] private TextMeshProUGUI textTimer;
    [SerializeField] private TextMeshProUGUI chestName;
    [SerializeField] private Button onButton;
    private ChestInfoSO chestInfoSO;

    private bool startUnloacked = false;

    public void SetImage(Sprite _image) => iconSprite.sprite = _image;

    public void GetName(string _chestName) => chestName.text = _chestName;
    public void GetChestInfoSO(ChestInfoSO _chestInfoSO)
    {
        chestInfoSO = _chestInfoSO;

    }

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
        if (chestInfoSO.chestStatus == ChestStatus.Locked)
        {
            GameService.Instance.SetChestItem(this);
            GameService.Instance.GetInfoHolderService().GetInfoHolderController().SetButtonPanelStatus(true);
        }
        else if (chestInfoSO.chestStatus == ChestStatus.Unlocked)
        {
            int rewardCoin = UnityEngine.Random.Range(chestInfoSO.reward.minCoin, chestInfoSO.reward.maxCoin);
            int rewardGem = UnityEngine.Random.Range(chestInfoSO.reward.minGems, chestInfoSO.reward.maxGems);
            GameService.Instance.GetInfoHolderService().GetInfoHolderController().CollectReward(rewardCoin, rewardGem);
            gameObject.SetActive(false);

        }
    }

    public void SetTime(float _time)
    {
        TimeSpan timeSpan = TimeSpan.FromSeconds(_time);
        textTimer.text = timeSpan.ToString(@"hh\:mm\:ss");
    }
    public void SetBoolTimer(bool _unlocked)
    {
        startUnloacked = _unlocked;
        GameService.Instance.GetInfoHolderService().GetInfoHolderController().SetButtonPanelStatus(false);
        chestInfoSO.chestStatus = ChestStatus.Unlocking;
    }

    private void Update()
    {
        if (startUnloacked)
        {
            StartTimer();
        }
    }

    private void StartTimer()
    {

        chestInfoSO.lockedTime -= Time.deltaTime;
        TimeSpan timeSpan = TimeSpan.FromSeconds(chestInfoSO.lockedTime);
        textTimer.text = timeSpan.ToString(@"hh\:mm\:ss");
        if (chestInfoSO.lockedTime <= 0)
        {
            startUnloacked = false;
            chestInfoSO.chestStatus = ChestStatus.Unlocked;
        }
    }

    public void ReduceTimerUsingGem(int gemTimer)
    {
        int gemUsed = Mathf.CeilToInt(chestInfoSO.lockedTime / gemTimer);
        GameService.Instance.GetInfoHolderService().GetInfoHolderController().SetButtonPanelStatus(false);
        GameService.Instance.GetInfoHolderService().GetInfoHolderController().UpdateGem(gemUsed);
        chestInfoSO.chestStatus = ChestStatus.Unlocked;
    }
}
