using UnityEngine;

namespace Poecc.Game.ValueObject {
  [CreateAssetMenu(fileName = "Mod_AddAttackDamage_", menuName = "ScriptableObjects/Item/Modifier/AddAttackDamage", order = 1)]
  public class AddAttackDamageMod : ModObjectBase {
    [SerializeField] public DamageType damageType;
  }
}