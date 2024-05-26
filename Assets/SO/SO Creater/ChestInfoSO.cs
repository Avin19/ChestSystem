using UnityEngine;

[CreateAssetMenu(fileName = " Chest ", menuName = " Create Chest")]
public class ChestInfoSO : ScriptableObject
{
    public Sprite chestImage;
    public float lockedTime;
    public ChestStatus chestStatus;
    public ChestType chestType;
    public Reward reward;

}
public enum ChestStatus
{
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
    public int coin;
    public int gems;
}