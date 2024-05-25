using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = " ChestInfoList", menuName = " ChestInfoList")]
public class ChestListSO : ScriptableObject
{
    [SerializeField] private List<ChestInfoSO> chestInfoSOs = new List<ChestInfoSO>();


    public List<ChestInfoSO> ChestInfoSOList => chestInfoSOs;
}
