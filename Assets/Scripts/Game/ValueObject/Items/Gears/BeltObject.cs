using UnityEngine;

namespace Poecc.Game.ValueObject {

    [CreateAssetMenu(fileName = "Item_Belt_", menuName = "ScriptableObjects/Item/Belt", order = 1)]
    public class BeltObject : ItemObjectBase
    {
        public BeltObject (){
          maxModCount = 6;
        }
    }
}

