using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InforHolderView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinText;
    [SerializeField] private TextMeshProUGUI gemText;
    [SerializeField] private TextMeshProUGUI notificationText;
    [SerializeField] private Button startTimer;
    [SerializeField] private Button gemBtn;
    [SerializeField] private Button generateBtn;

    [SerializeField] private RectTransform panelBtn;


    public void SetPanelButton(bool panelStatus) => panelBtn.gameObject.SetActive(panelStatus);

    private void OnEnable()
    {
        startTimer.onClick.AddListener(OnStartButton);
        gemBtn.onClick.AddListener(OnGemButtonClick);
        generateBtn.onClick.AddListener(OnGenerateButtonClick);
    }

    private void OnGenerateButtonClick()
    {
        GameService.Instance.GetChestService().GetChestController().SettingUpChest();
        generateBtn.gameObject.SetActive(false);
    }

    private void OnGemButtonClick()
    {

    }

    private void OnStartButton()
    {
        GameService.Instance.GetChestItem().SetBoolTimer(true);
    }

    private void OnDisable()
    {
        startTimer.onClick.RemoveListener(OnStartButton);
        gemBtn.onClick.RemoveListener(OnGemButtonClick);
        generateBtn.onClick.RemoveListener(OnGenerateButtonClick);

    }

    public void SetGemCoin(int coin, int gem)
    {
        coinText.text = coin.ToString();
        gemText.text = gem.ToString();
    }






}
