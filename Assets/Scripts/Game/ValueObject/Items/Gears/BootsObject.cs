using UnityEngine;

namespace Poecc.Game.ValueObject {
    [CreateAssetMenu(fileName = "Item_Boots_", menuName = "ScriptableObjects/Item/Boots", order = 1)]
    public class BootsObject : ItemObjectBase
    {
        public BootsObject (){
          maxModCount = 6;
        }
    }
}

