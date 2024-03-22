using Poecc.Game.IModel;
using UnityEngine;
using Poecc.Game.ValueObject;
using VContainer;
using System.Collections.Generic;

namespace Poecc.Game.System {
  public class Initializer : MonoBehaviour {
    private ICharacterService _characterService;
    private IItemizeService _itemizeService;
    private IDungeonService _dungeonService;
    [Inject]
    public void Constructor(
      ICharacterService characterService,
      IItemizeService itemizeService,
      IDungeonService dungeonService
    ){
      _characterService = characterService;
      _itemizeService = itemizeService;
      _dungeonService = dungeonService;
    }

    [SerializeField] private WeaponObject _mainHand;
    [SerializeField] private WeaponObject _offHand;
    [SerializeField] private BootsObject _boots;
    [SerializeField] private BeltObject _belt;
    [SerializeField] private GlovesObject _gloves;
    [SerializeField] private BodyArmourObject _bodyArmour;
    [SerializeField] private HelmetObject _helmet;
    [SerializeField] private CharClassObjectBase _charClass;

    [SerializeField] private List<DungeonObject> _dungeonList;
    public void Start(){
      var param = new ModCraftParams();
      var itemLevel = 0;
      var mainHand = _itemizeService.createItem(_mainHand, itemLevel, param);
      var offHand = _itemizeService.createItem(_offHand, itemLevel, param);
      var boots = _itemizeService.createItem(_boots, itemLevel, param);
      var belt = _itemizeService.createItem(_belt, itemLevel, param);
      var gloves = _itemizeService.createItem(_gloves, itemLevel, param);
      var bodyArmour = _itemizeService.createItem(_bodyArmour, itemLevel, param);
      var helmet = _itemizeService.createItem(_helmet, itemLevel, param);
      var charClass = _charClass;
      var ch = new CharacterObject(mainHand, offHand, bodyArmour, helmet, boots, belt, gloves, charClass );
      _characterService.Load(ch);

      _dungeonService.setDungeonList(_dungeonList);
    }
  }
}