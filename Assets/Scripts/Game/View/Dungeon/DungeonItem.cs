using System.Collections;
using System.Collections.Generic;
using Poecc.Game.ValueObject;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Poecc.Game.View {
    public class DungeonItem : MonoBehaviour
    {
        [HideInInspector] private DungeonObject _dungeonObject;
        [SerializeField] public TextMeshProUGUI dungeonNameText;
        [SerializeField] public TextMeshProUGUI dungeonLevelText;
        
        public void setDungeonObject(DungeonObject dungeonObject){
            _dungeonObject = dungeonObject;
            dungeonNameText.text = dungeonObject.dungeonName;
            dungeonLevelText.text = "Lv." + dungeonObject.dungeonLevel.ToString();
        }
    }
}
