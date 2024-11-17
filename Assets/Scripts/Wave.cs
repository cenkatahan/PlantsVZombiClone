using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "Wave", menuName = "ScriptableObjects/Wave", order = 1)]
class Wave: ScriptableObject
{
    public int id;
    public int size;
}
