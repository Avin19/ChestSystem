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

    public void SetImage(Sprite _image) => iconSprite = _image;
    public void GetName(string _chestName) => chestName.text = _chestName;

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
        GameService.Instance.GetInfoHolderService().GetInfoHolderController().SetButtonPanelStatus(true);
    }
}
