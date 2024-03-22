using UnityEngine;

namespace Poecc.Game.ValueObject {
    [CreateAssetMenu(fileName = "Item_Gloves_", menuName = "ScriptableObjects/Item/Gloves", order = 1)]
    public class GlovesObject : ItemObjectBase
    {
        public GlovesObject (){
          maxModCount = 6;
        }
    }
}

