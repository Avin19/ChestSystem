using UnityEngine;

[CreateAssetMenu(fileName = " Chest ", menuName = " Create Chest")]
public class ChestInfoSO : ScriptableObject
{
    public Sprite chestImage;
    public float lockedTime;
    public ChestStatus chestStatus = ChestStatus.Locked;
    public ChestType chestType;
    public Reward reward;

}
public enum ChestStatus
{
    Locked,
    Unlocking,
    Unlocked,
    Collected
}
public enum ChestType
{
    Common,
    Rare,
    Epic,
    Legend
}
[System.Serializable]
public struct Reward
{
    public int maxCoin;
    public int minCoin;
    public int maxGems;
    public int minGems;
}