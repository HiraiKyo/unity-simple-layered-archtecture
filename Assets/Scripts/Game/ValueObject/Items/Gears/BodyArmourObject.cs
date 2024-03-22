using UnityEngine;

namespace Poecc.Game.ValueObject {
    [CreateAssetMenu(fileName = "Item_BodyArmour_", menuName = "ScriptableObjects/Item/BodyArmour", order = 1)]
    public class BodyArmourObject : ItemObjectBase
    {
        public BodyArmourObject (){
          maxModCount = 6;
        }
    }
}
