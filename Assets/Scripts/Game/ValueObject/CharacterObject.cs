namespace Poecc.Game.ValueObject {
  public class CharacterObject {
    public ItemInstanceObject<WeaponObject> mainHand;
    public ItemInstanceObject<WeaponObject> offHand;
    public ItemInstanceObject<BodyArmourObject> bodyArmour;
    public ItemInstanceObject<HelmetObject> helmet;
    public ItemInstanceObject<BootsObject> boots;
    public ItemInstanceObject<BeltObject> belt;
    public ItemInstanceObject<GlovesObject> gloves;
    public CharClassObjectBase charClass;
    public CharacterObject(
      ItemInstanceObject<WeaponObject> a_mainHand,
      ItemInstanceObject<WeaponObject> a_offHand,
      ItemInstanceObject<BodyArmourObject> a_bodyArmour,
      ItemInstanceObject<HelmetObject> a_helmet,
      ItemInstanceObject<BootsObject> a_boots,
      ItemInstanceObject<BeltObject> a_belt,
      ItemInstanceObject<GlovesObject> a_gloves,
      CharClassObjectBase a_charClass
      )
    {
      mainHand = a_mainHand;
      offHand = a_offHand;
      belt = a_belt;
      bodyArmour = a_bodyArmour;
      helmet = a_helmet;
      boots = a_boots;
      gloves = a_gloves;
      charClass = a_charClass;
    }
  }
}