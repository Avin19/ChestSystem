using UnityEngine;

namespace chestSystem
{
    [CreateAssetMenu(fileName = "Player Status", menuName = " Status")]
    public class SOPlayerStatus : ScriptableObject
    {
        public int coinAmount;
        public int gemAmount;

    }

}

