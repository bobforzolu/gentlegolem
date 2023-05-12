using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data Directory", menuName = "Data/Player Data/Data Container")]
public class PlayerDataDirectory : ScriptableObject
{
    public MovementData movement;
}
