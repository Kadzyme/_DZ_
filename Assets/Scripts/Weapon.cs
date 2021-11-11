using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Weapon", menuName = "Weapon", order = 51)]
public class Weapon : ScriptableObject
{
    public float damage = 10f;
    public float range = 100f;
}
