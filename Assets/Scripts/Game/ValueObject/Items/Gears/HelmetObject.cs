using UnityEngine;

namespace Poecc.Game.ValueObject {
    [CreateAssetMenu(fileName = "Item_Helmet_", menuName = "ScriptableObjects/Item/Helmet", order = 1)]
    public class HelmetObject : ItemObjectBase
    {
        public HelmetObject (){
          maxModCount = 6;
        }
    }
}
