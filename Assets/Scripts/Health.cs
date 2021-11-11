using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health = 100f;

    public void TakeDamage(float damage, string nameOfKiller)
    {
        health -= damage;
        if (health <= 0f)
        {
            Destroy(gameObject);
            CreateCombatLog(nameOfKiller);
        }            
    }
    private void CreateCombatLog(string nameOfKiller)
    {
        CombatLogCreator combatLog = gameObject.transform.GetComponent<CombatLogCreator>();
        if (combatLog != null)
        {
            combatLog.CreateCombatLog(nameOfKiller);
        }
    }
}