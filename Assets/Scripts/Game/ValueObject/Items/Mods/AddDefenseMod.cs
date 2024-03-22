using UnityEngine;

namespace Poecc.Game.ValueObject {
  [CreateAssetMenu(fileName = "Mod_AddDefense_", menuName = "ScriptableObjects/Item/Modifier/AddDefense", order = 1)]
  public class AddDefenseMod : ModObjectBase {
    [SerializeField] public DefenseType defenseType;
  }
}