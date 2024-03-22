using Poecc.Game.ValueObject;
using Poecc.Game.IModel;
using UnityEngine;
using System.Linq;
using System.Collections.Generic;
using System;

namespace Poecc.Game.Model {
  public class ItemizeModel : IItemizeModel {
    public ItemInstanceObject<T> createItem<T>(T baseItem, int itemLevel, ModCraftParams param) where T: ItemObjectBase {
      // TODO: アイテム生成ロジックをここにかく
      List<ModObjectBase> table = baseItem.modTable;
      List<(ModObjectBase, int, int)> chosenMods = new List<(ModObjectBase, int, int)>();
      for(int i=0; i<6; i++){
        // TODO: まずModが付与されるかどうかの確率判定
        bool isModUnslotted = false;
        if (isModUnslotted){
          continue;
        }
        // Mod付与判定
        var (mod, tier, value) = rollModifiers(table, itemLevel, param);
        // TODO: 同一Mod付与済みの場合はリロール

        // TODO: 10回リロールして失敗した場合はエラー回避のためにbreak

        chosenMods.Add((mod, tier, value));
      }
      var item = new ItemInstanceObject<T>(baseItem, chosenMods);

      return item;
    }

    /// <summary>
    /// Modifierロール
    /// </summary>
    /// <param name="table"></param>
    /// <param name="itemLevel"></param>
    /// <param name="param"></param>
    /// <returns>(ModObjectBase mod, int tierIndex, int rolledValue)</returns>
    private (ModObjectBase, int, int) rollModifiers(List<ModObjectBase> table, int itemLevel, ModCraftParams param){
      int totalChance = table.Sum(_ => _.chanceTotal(itemLevel)); // itemLevelを満たすModTierを抽出
      int roll = UnityEngine.Random.Range(0, totalChance); // ダイスロール
      var (index, diff) = getRolledIndex(table.Select(_ => _.chanceTotal(itemLevel)), roll);
      ModObjectBase rolledMod = table[index]; // ダイスロール結果により選ばれたMod
      var (tierIndex, _) = getRolledIndex(rolledMod.tiers.Select(_ => itemLevel >= _.requiredItemLevel ? _.chance : 0), diff);
      var rolledTier = rolledMod.tiers[tierIndex];// ダイスロール結果により選ばれたTier
      int rolledValue = UnityEngine.Random.Range(rolledTier.min, rolledTier.max + 1);// Mod+Tierの抽選後、Tierの最大・最小幅で値をロール

      return (rolledMod, tierIndex, rolledValue);
    }

    private (int, int) getRolledIndex(IEnumerable<int> numbers, int value){
      var result = numbers
          .Select((num, index) => new { Sum = numbers.Take(index + 1).Sum(), Index = index })
          .FirstOrDefault(x => x.Sum >= value);
      if (result != null)
      {
        return (result.Index, result.Sum - value);
      }
      else
      {
        // TODO: エラー管理
        // FIXME: アイテムにModが設定されていなかったり、ModにTierが無かったりするとエラーになる。エラーログをもうちょいわかりやすくしたい
        throw new InvalidOperationException("Cannot roll mod or tier.");
      }
    }
  }
}