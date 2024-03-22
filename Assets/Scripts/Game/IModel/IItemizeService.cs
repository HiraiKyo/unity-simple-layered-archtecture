using Poecc.Game.ValueObject;

namespace Poecc.Game.IModel {
  public interface IItemizeService {
    /// <summary>
    /// アイテムを作成する
    /// </summary>
    /// <returns></returns>
    public ItemInstanceObject<T> createItem<T>(T baseItem, int itemLevel, ModCraftParams param) where T: ItemObjectBase;
  }
}