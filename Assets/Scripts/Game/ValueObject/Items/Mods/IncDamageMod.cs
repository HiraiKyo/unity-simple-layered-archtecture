using UnityEngine;

namespace Poecc.Game.ValueObject {
  [CreateAssetMenu(fileName = "Mod_IncDamage_", menuName = "ScriptableObjects/Item/Modifier/IncDamage", order = 1)]
  public class IncDamageMod : ModObjectBase {
    [SerializeField] public DamageType damageType;
  }
}