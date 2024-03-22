using UnityEngine;

namespace Poecc.Game.ValueObject {
  [CreateAssetMenu(fileName = "Mod_AddResist_", menuName = "ScriptableObjects/Item/Modifier/AddResist", order = 1)]
  public class AddResistMod : ModObjectBase {
    [SerializeField] public DamageType damageType;
  }
}