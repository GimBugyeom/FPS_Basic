using UnityEngine;
[CreateAssetMenu(fileName = "Default Gun", menuName = "50/Gun", order = 100)]
public class GunSO : ScriptableObject
{
    [field: SerializeField] public float coolTime { get; private set; }
    [field: SerializeField] public float speed { get; private set; }
}
