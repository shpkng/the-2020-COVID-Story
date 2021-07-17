using UnityEngine;

namespace Editor
{
    [CreateAssetMenu(fileName = "new Tweet", menuName = "Data/Tweet", order = 0)]
    public class Tweets : ScriptableObject
    {
        [SerializeField] private Tweet[] tweets;
    }
}