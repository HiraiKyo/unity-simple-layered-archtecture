using Poecc.Game.ValueObject;
using VContainer;

namespace Poecc.Game.IModel {
  public class ItemizeService : IItemizeService {
    private IItemizeModel _itemizeModel;
    [Inject]
    public ItemizeService(
      IItemizeModel itemizeModel
    ){
      _itemizeModel = itemizeModel;
    }
    public ItemInstanceObject<T> createItem<T>(T baseItem, int itemLevel, ModCraftParams param) where T: ItemObjectBase {
      return _itemizeModel.createItem(baseItem, itemLevel, param);  
    }
  }
}