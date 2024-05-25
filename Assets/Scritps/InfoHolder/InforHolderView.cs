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

    [SerializeField] private RectTransform panelBtn;


    public void SetPanelButton(bool panelStatus) => panelBtn.gameObject.SetActive(panelStatus);







}
