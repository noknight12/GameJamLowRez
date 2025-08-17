using UnityEngine;

[CreateAssetMenu(fileName = "Buff", menuName = "Scriptable Objects/Buff")]
public class Buff : ScriptableObject
{
    public string buffName;
    public DoBuff buffFile;
}
