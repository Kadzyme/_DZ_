using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombatLogCreator : MonoBehaviour
{
    [SerializeField] private Text combatLog;
    [SerializeField] private Text bossCombatLog;
    [SerializeField] private string nameOfUnit;
    [SerializeField] private Transform transform;

    public void CreateCombatLog(string nameOfKiller)
    {
        Text thisCombatLog;
        if (gameObject.tag != "Boss")
        {
            thisCombatLog = Instantiate(combatLog, transform);
        }
        else
        {
            thisCombatLog = Instantiate(bossCombatLog, transform);
        }
        thisCombatLog.text = ($"{nameOfUnit} was killed by {nameOfKiller}");
    }
}
