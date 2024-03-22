using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace Poecc.Game.ValueObject {
    [CreateAssetMenu(fileName = "Item_Weapon_", menuName = "ScriptableObjects/Item/Weapon", order = 1)]
    public class WeaponObject : ItemObjectBase
    {
        public WeaponObject (){
          maxModCount = 6;
        }
    }
}
