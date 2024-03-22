using R3;
using Poecc.Game.ValueObject;

namespace Poecc.Game.IModel {
  public interface ICharacterService {
    /// <summary>
    /// キャラクターのロード
    /// </summary>
    void Load(
      CharacterObject ch
    );

    /// <summary>
    /// 現在装備中の武器メインハンド
    /// </summary>
    /// <value></value>
    ReadOnlyReactiveProperty<string> chName { get; }
    /// <summary>
    /// 現在装備中の武器メインハンドイベントリスナー
    /// </summary>
    /// <value></value>
    Observable<string> chNameAsObservable { get; }

    /// <summary>
    /// 現在装備中の武器メインハンド
    /// </summary>
    /// <value></value>
    ReadOnlyReactiveProperty<ItemInstanceObject<WeaponObject>> mainHand { get; }
    /// <summary>
    /// 現在装備中の武器メインハンドイベントリスナー
    /// </summary>
    /// <value></value>
    Observable<ItemInstanceObject<WeaponObject>> mainHandAsObservable { get; }
    /// <summary>
    /// メインハンド装備の変更
    /// </summary>
    /// <value></value>
    bool EquipMainHand(ItemInstanceObject<WeaponObject> weapon);

    /// <summary>
    /// 現在装備中のオフハンド武器
    /// </summary>
    /// <value></value>
    ReadOnlyReactiveProperty<ItemInstanceObject<WeaponObject>> offHand { get; }
    /// <summary>
    /// 現在装備中のオフハンドイベントリスナー
    /// </summary>
    /// <value></value>
    Observable<ItemInstanceObject<WeaponObject>> offHandAsObservable { get; }
    /// <summary>
    /// オフハンド装備の変更
    /// </summary>
    /// <value></value>
    bool EquipOffHand(ItemInstanceObject<WeaponObject> weapon);

    /// <summary>
    /// 現在装備中のヘルメット
    /// </summary>
    /// <value></value>
    ReadOnlyReactiveProperty<ItemInstanceObject<HelmetObject>> helmet { get; }
    /// <summary>
    /// 現在装備中のヘルメットイベントリスナー
    /// </summary>
    /// <value></value>
    Observable<ItemInstanceObject<HelmetObject>> helmetAsObservable { get; }
    /// <summary>
    /// ヘルメットの装備変更
    /// </summary>
    /// <value></value>
    bool EquipHelmet(ItemInstanceObject<HelmetObject> helmet);

    /// <summary>
    /// 現在装備中のボディアーマー
    /// </summary>
    /// <value></value>
    ReadOnlyReactiveProperty<ItemInstanceObject<BodyArmourObject>> bodyArmour { get; }
    /// <summary>
    /// 現在装備中のボディアーマーイベントリスナー
    /// </summary>
    /// <value></value>
    Observable<ItemInstanceObject<BodyArmourObject>> bodyArmourAsObservable { get; }
    /// <summary>
    /// ボディアーマーの装備変更
    /// </summary>
    /// <value></value>
    bool EquipBodyArmour(ItemInstanceObject<BodyArmourObject> bodyArmour);

    /// <summary>
    /// 現在装備中のグローブ
    /// </summary>
    /// <value></value>
    ReadOnlyReactiveProperty<ItemInstanceObject<GlovesObject>> gloves { get; }
    /// <summary>
    /// 現在装備中のグローブ
    /// </summary>
    /// <value></value>
    Observable<ItemInstanceObject<GlovesObject>> glovesAsObservable { get; }
    /// <summary>
    /// グローブの装備変更
    /// </summary>
    /// <value></value>
    bool EquipGloves(ItemInstanceObject<GlovesObject> gloves);

    /// <summary>
    /// 現在装備中のブーツ
    /// </summary>
    /// <value></value>
    ReadOnlyReactiveProperty<ItemInstanceObject<BootsObject>> boots { get; }
    /// <summary>
    /// 現在装備中のブーツ
    /// </summary>
    /// <value></value>
    Observable<ItemInstanceObject<BootsObject>> bootsAsObservable { get; }
    /// <summary>
    /// ブーツの装備変更
    /// </summary>
    /// <value></value>
    bool EquipBoots(ItemInstanceObject<BootsObject> boots);

    /// <summary>
    /// 現在装備中のベルト
    /// </summary>
    /// <value></value>
    ReadOnlyReactiveProperty<ItemInstanceObject<BeltObject>> belt { get; }
    /// <summary>
    /// 現在装備中のベルト
    /// </summary>
    /// <value></value>
    Observable<ItemInstanceObject<BeltObject>> beltAsObservable { get; }
    /// <summary>
    /// ベルトの装備変更
    /// </summary>
    /// <value></value>
    bool EquipBelt(ItemInstanceObject<BeltObject> belt);

    /// <summary>
    /// キャラクターのベーススタッツ
    /// </summary>
    ReadOnlyReactiveProperty<CharStatsObject> baseStats { get; }
    /// <summary>
    /// キャラクターのベーススタッツリスナー
    /// </summary>
    /// <value></value>
    Observable<CharStatsObject> baseStatsAsObservable { get; }
    /// <summary>
    /// キャラクターのベーススタッツ変更
    /// </summary>
    bool ChangeBaseStats(CharStatsObject stats);
  }
}