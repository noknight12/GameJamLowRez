using System.Collections.Generic;
using UnityEngine;

public class ApplyBuff : MonoBehaviour
{
    
    public List<Buff> ActiveBuffs = new List<Buff>();

    public int Apply(Ability ability)
    {
        if (ability is Attack)
        {
            foreach (Buff buff in ActiveBuffs)
            {
               int buffedDmg = buff.buffFile.DmgModifier(ability.stat);
                return buffedDmg;
            }
        }
        else if (ability is Defense)
        {
            foreach (Buff buff in ActiveBuffs)
            {
                int buffedDef = buff.buffFile.DefenseModifier(ability.stat);
                return buffedDef;
            }
        }
        else if (ability is Heal)
        {
            foreach (Buff buff in ActiveBuffs)
            {
                int buffedHeal = buff.buffFile.HealModifier(ability.stat);
                return buffedHeal;
            }
        }
        return 0;
        
    }

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
