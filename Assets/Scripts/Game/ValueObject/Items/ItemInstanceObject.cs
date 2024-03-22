using System.Collections.Generic;
using UnityEngine;

namespace Poecc.Game.ValueObject {
  public class ItemInstanceObject<T> where T: ItemObjectBase {
    public T objectBase { get; private set; }
    public List<(ModObjectBase mod, int tierIndex, int rolledValue)> mods { get; private set; }
    public ItemInstanceObject(
      T objBase,
      List<(ModObjectBase mod, int tierIndex, int rolledValue)> modList
    ){
      objectBase = objBase;
      mods = modList;
    }
  }
}