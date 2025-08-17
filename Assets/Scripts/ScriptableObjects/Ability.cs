using UnityEngine;

[CreateAssetMenu(fileName = "Ability", menuName = "Scriptable Objects/Ability")]
public class Ability : ScriptableObject
{
    [SerializeField]
    public int stat;
    [SerializeField]
    public string abilityName;
    [SerializeField]
    public string animName;
    [SerializeField]
    public Sprite icon;
}
