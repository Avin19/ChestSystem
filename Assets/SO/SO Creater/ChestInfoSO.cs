using UnityEngine;

[CreateAssetMenu(fileName = " Chest ", menuName = " Create Chest")]
public class ChestInfoSO : ScriptableObject
{
    public Sprite chestImage;
    public float lockedTime;
    public float unlockTimer;

    public bool unlocked;

    public bool collected;

}
