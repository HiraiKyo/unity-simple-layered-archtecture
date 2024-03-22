using System.Collections.Generic;
using UnityEngine;
using VContainer;

using Poecc.Game.IModel;
using System.Linq;

namespace Poecc.Game.ValueObject {
  [CreateAssetMenu(fileName = "Dungeon_", menuName = "ScriptableObjects/Dungeon", order = 1)]
  public class DungeonObject : ScriptableObject {
    private IItemizeService _itemizeService;
    [Inject]
    public void Constructor(
      IItemizeService itemizeService
    ){
      _itemizeService = itemizeService;
    }

    // ダンジョンパラメータ
    [SerializeField] public readonly string uid;
    [SerializeField] public string dungeonName;
    [SerializeField] public int dungeonLevel;
    [SerializeField] int dungeonExperience = 10000;

    public DungeonObject(){
      uid = CommonFunctions.GenUUID();
      dungeonName = "default dungeon name";
      dungeonLevel = 100;
    }

    // ダンジョン用関連メソッド
    public int calDungeonRewardExperience(){
      // TODO: ダンジョン経験値算出式
      return dungeonExperience;
    }

    [SerializeField] List<ItemObjectBase> dungeonDropTable;
    public List<ItemInstanceObject<ItemObjectBase>> calDungeonRewardItems(){
      // TODO: ダンジョンドロップ算出式
      int itemLevel = dungeonLevel; // いったんダンジョンレベルと同じアイテムレベルのアイテムが落ちるようにする
      ModCraftParams param = new ModCraftParams(); // Modロール用変数はまだ何も決まってない

      // ドロップするアイテムベースが決まったら、アイテムロールを行う
      List<ItemInstanceObject<ItemObjectBase>> drops = dungeonDropTable.Select(_ => _itemizeService.createItem(_, itemLevel, param)).ToList();
      
      return drops;
    }
  }
}