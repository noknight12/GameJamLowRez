using UnityEngine;

public abstract class DoBuff : MonoBehaviour
{
    public abstract int DmgModifier(int baseDamage);
    public abstract int DefenseModifier(int baseDefense);
    public abstract int HealModifier(int baseHeal);

  
}
