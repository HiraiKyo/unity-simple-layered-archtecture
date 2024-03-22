using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace Poecc.Game.ValueObject {
    public class ModObjectBase : ScriptableObject
    {
        [HideInInspector] private string _uid;
        public string uid => _uid;
        [SerializeField] public string modName;
        [SerializeField] public List<ModValueRange> tiers;
        public ModObjectBase(){
            _uid = CommonFunctions.GenUUID();
            modName = "Default Modifier";
            tiers = new List<ModValueRange>();
        }
        public int chanceTotal(int itemLevel){
            var total = tiers.Sum(tier => {
                if(itemLevel >= tier.requiredItemLevel){
                    return tier.chance;
                }else{
                    return 0;
                }
            });
            return total;
        } 
    }
}
