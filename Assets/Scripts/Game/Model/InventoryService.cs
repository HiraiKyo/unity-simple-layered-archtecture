using Poecc.Game.IModel;
using R3;
using ObservableCollections;
using Poecc.Game.ValueObject;
using System.Collections.Generic;
using System.Linq;

namespace Poecc.Game.Model {
  public class InventoryService : IInventoryService {
    private ObservableList<ItemInstanceObject<ItemObjectBase>> _inventory = new ObservableList<ItemInstanceObject<ItemObjectBase>>();
    public List<ItemInstanceObject<ItemObjectBase>> inventory => _inventory.ToList();
    public Observable<CollectionAddEvent<ItemInstanceObject<ItemObjectBase>>> inventoryAddAsObservable => _inventory.ObserveAdd();
    public Observable<CollectionReplaceEvent<ItemInstanceObject<ItemObjectBase>>> inventoryReplaceAsObservable => _inventory.ObserveReplace();
    public Observable<CollectionRemoveEvent<ItemInstanceObject<ItemObjectBase>>> inventoryRemoveAsObservable => _inventory.ObserveRemove();

    public void Load(List<ItemInstanceObject<ItemObjectBase>> itemList){
      // FIXME: この追加方法はインベントリが多くなると重いかも
      foreach (var item in itemList){
        _inventory.Add(item);
      }
    }

    public void addItem(ItemInstanceObject<ItemObjectBase> item){
      _inventory.Add(item);
    }
  }
}