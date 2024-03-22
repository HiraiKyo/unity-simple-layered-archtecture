using Poecc.Game.ValueObject;
using R3;
using ObservableCollections;
using System.Collections.Generic;

namespace Poecc.Game.IModel {
  public interface IInventoryService {
    /// <summary>
    /// インベントリのロード
    /// </summary>
    /// <param name="itemList"></param>
    void Load(
      List<ItemInstanceObject<ItemObjectBase>> itemList
    );

    /// <summary>
    /// インベントリを取得
    /// </summary>
    /// <value></value>
    public List<ItemInstanceObject<ItemObjectBase>> inventory { get; }
    /// <summary>
    /// インベントリへのアイテム追加イベントリスナー
    /// </summary>
    /// <value></value>
    public Observable<CollectionAddEvent<ItemInstanceObject<ItemObjectBase>>> inventoryAddAsObservable { get; }
    /// <summary>
    /// インベントリのアイテム更新イベントリスナー
    /// </summary>
    /// <value></value>
    public Observable<CollectionReplaceEvent<ItemInstanceObject<ItemObjectBase>>> inventoryReplaceAsObservable { get; }
    /// <summary>
    /// インベントリのアイテム削除イベントリスナー
    /// </summary>
    /// <value></value>
    public Observable<CollectionRemoveEvent<ItemInstanceObject<ItemObjectBase>>> inventoryRemoveAsObservable { get; }

    /// <summary>
    /// アイテムをインベントリに追加
    /// </summary>
    /// <param name="item"></param>
    public void addItem(ItemInstanceObject<ItemObjectBase> item);
  }
}