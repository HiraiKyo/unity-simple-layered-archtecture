using Poecc.Game.IModel;
using Poecc.Game.ValueObject;
using R3;

namespace Poecc.Game.Model {
  public class CharacterService : ICharacterService {
        // キャラクターのロード
        public void Load(
            CharacterObject ch
        ){
            EquipMainHand(ch.mainHand);
            EquipOffHand(ch.offHand);
            EquipBoots(ch.boots);
            EquipGloves(ch.gloves);
            EquipBelt(ch.belt);
            EquipBodyArmour(ch.bodyArmour);
            EquipHelmet(ch.helmet);
            ChangeBaseStats(ch.charClass.baseClassStats);
        }

        // キャラクター名
        private ReactiveProperty<string> _chName = new ReactiveProperty<string>("デフォルト名");
        public ReadOnlyReactiveProperty<string> chName => _chName;
        public Observable<string> chNameAsObservable => _chName;        

        // 装備
        private ReactiveProperty<ItemInstanceObject<WeaponObject>> _mainHand = new ReactiveProperty<ItemInstanceObject<WeaponObject>>(null);
        public ReadOnlyReactiveProperty<ItemInstanceObject<WeaponObject>> mainHand => _mainHand;
        public Observable<ItemInstanceObject<WeaponObject>> mainHandAsObservable => _mainHand;
        public bool EquipMainHand(ItemInstanceObject<WeaponObject> weapon)
        {
            _mainHand.OnNext(weapon);
            return true;
        }

        private ReactiveProperty<ItemInstanceObject<WeaponObject>> _offHand = new ReactiveProperty<ItemInstanceObject<WeaponObject>>(null);
        public ReadOnlyReactiveProperty<ItemInstanceObject<WeaponObject>> offHand => _offHand;
        public Observable<ItemInstanceObject<WeaponObject>> offHandAsObservable => _offHand;
        public bool EquipOffHand(ItemInstanceObject<WeaponObject> weapon)
        {
            _offHand.OnNext(weapon);
            return true;
        }

        private ReactiveProperty<ItemInstanceObject<BodyArmourObject>> _bodyArmour = new ReactiveProperty<ItemInstanceObject<BodyArmourObject>>(null);
        public ReadOnlyReactiveProperty<ItemInstanceObject<BodyArmourObject>> bodyArmour => _bodyArmour;
        public Observable<ItemInstanceObject<BodyArmourObject>> bodyArmourAsObservable => _bodyArmour;
        public bool EquipBodyArmour(ItemInstanceObject<BodyArmourObject> bodyArmour)
        {
            _bodyArmour.OnNext(bodyArmour);
            return true;
        }

        private ReactiveProperty<ItemInstanceObject<HelmetObject>> _helmet = new ReactiveProperty<ItemInstanceObject<HelmetObject>>(null);
        public ReadOnlyReactiveProperty<ItemInstanceObject<HelmetObject>> helmet => _helmet;
        public Observable<ItemInstanceObject<HelmetObject>> helmetAsObservable => _helmet;
        public bool EquipHelmet(ItemInstanceObject<HelmetObject> helmet)
        {
            _helmet.OnNext(helmet);
            return true;
        }

        private ReactiveProperty<ItemInstanceObject<BootsObject>> _boots = new ReactiveProperty<ItemInstanceObject<BootsObject>>(null);
        public ReadOnlyReactiveProperty<ItemInstanceObject<BootsObject>> boots => _boots;
        public Observable<ItemInstanceObject<BootsObject>> bootsAsObservable => _boots;
        public bool EquipBoots(ItemInstanceObject<BootsObject> boots)
        {
            _boots.OnNext(boots);
            return true;
        }

        private ReactiveProperty<ItemInstanceObject<GlovesObject>> _gloves = new ReactiveProperty<ItemInstanceObject<GlovesObject>>(null);
        public ReadOnlyReactiveProperty<ItemInstanceObject<GlovesObject>> gloves => _gloves;
        public Observable<ItemInstanceObject<GlovesObject>> glovesAsObservable => _gloves;
        public bool EquipGloves(ItemInstanceObject<GlovesObject> gloves)
        {
            _gloves.OnNext(gloves);
            return true;
        }

        private ReactiveProperty<ItemInstanceObject<BeltObject>> _belt = new ReactiveProperty<ItemInstanceObject<BeltObject>>(null);
        public ReadOnlyReactiveProperty<ItemInstanceObject<BeltObject>> belt => _belt;
        public Observable<ItemInstanceObject<BeltObject>> beltAsObservable => _belt;
        public bool EquipBelt(ItemInstanceObject<BeltObject> belt)
        {
            _belt.OnNext(belt);
            return true;
        }


        // 基礎スタッツ
        private ReactiveProperty<CharStatsObject> _baseStats = new ReactiveProperty<CharStatsObject>();
        public ReadOnlyReactiveProperty<CharStatsObject> baseStats => _baseStats;
        public Observable<CharStatsObject> baseStatsAsObservable => _baseStats;
        public bool ChangeBaseStats(CharStatsObject stats){
            _baseStats.OnNext(stats);
            return true;
        }
    }
}