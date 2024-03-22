using UnityEngine;
using UnityEngine.UI; 
using R3;
using TMPro;
using Poecc.Game.IModel;
using VContainer;

namespace Poecc.Game.View
{
    public class Equip : MonoBehaviour
    {
        private ICharacterService _characterService;
        [SerializeField] public Image mainHandImage;
        [SerializeField] public Image offHandImage;
        [SerializeField] public Image helmetImage;
        [SerializeField] public Image bodyArmorImage;
        [SerializeField] public Image gloveImage;
        [SerializeField] public Image bootsImage;
        [SerializeField] public Image beltImage;

        [Inject]
        public void Constructor
        (
            ICharacterService characterService
        )
        {
            _characterService = characterService;
        }

        void Start()
        {
            _characterService.helmetAsObservable.Subscribe(
               _ => {
                    if(_ == null) {
                        helmetImage.sprite = null;
                    } else {
                        helmetImage.sprite = Sprite.Create(_.objectBase.image,new Rect(0,0,_.objectBase.image.width,_.objectBase.image.height),Vector2.zero);
                    }
                }
            ).AddTo(this);

        }
    }
}