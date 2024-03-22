using System.Collections.Generic;

namespace Poecc.Game.ValueObject {
  public class RewardObject {
    public readonly string uuid;
    public readonly int experience;
    public readonly List<ItemInstanceObject<ItemObjectBase>> items;
    public RewardObject(
      int exp,
      List<ItemInstanceObject<ItemObjectBase>> itms
    ){
      uuid = CommonFunctions.GenUUID();
      experience = exp;
      items = itms;
    }
  }
}