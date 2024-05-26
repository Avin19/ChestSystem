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
    private InfoHolderController infoHolderController;

    private void Start()
    {
        infoHolderController = GameService.Instance.GetInfoHolderService().GetInfoHolderController();
    }

    public void SetPanelButton(bool panelStatus) => panelBtn.gameObject.SetActive(panelStatus);

    private void OnEnable()
    {
        startTimer.onClick.AddListener(OnStartButton);
        gemBtn.onClick.AddListener(OnGemButtonClick);
        generateBtn.onClick.AddListener(OnGenerateButtonClick);
    }

    private void OnGenerateButtonClick()
    {
        infoHolderController.OnGenerateButtonClick();
    }

    private void OnGemButtonClick()
    {
        // Check gem amount
        //reduce the time 
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





}
