using UnityEngine;
using System.Collections.Generic;

namespace Poecc.Game.ValueObject {
    public class ItemObjectBase : ScriptableObject
    {
        // マスターデータ利用
        public string uid;
        [SerializeField] public string itemName;
        [SerializeField] public Texture2D icon;
        [SerializeField] public Texture2D image;
        [HideInInspector] public int requiredLevel;
        [HideInInspector] public int maxModCount { get; protected set; }
        [SerializeField] public List<ModObjectBase> modTable;
        public ItemObjectBase(){
            uid = CommonFunctions.GenUUID();
            itemName = "Default Item Name";
            requiredLevel = 0;
            modTable = new List<ModObjectBase>();
        }
    }
}
