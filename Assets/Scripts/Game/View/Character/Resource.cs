using UnityEngine;
using R3;
using TMPro;
using Poecc.Game.IModel;
using VContainer;

namespace Poecc.Game.View {
    public class Resource : MonoBehaviour
    {
        private ICharacterService _characterService;
        [SerializeField] public TextMeshProUGUI Text;

        [Inject]
        public void Constructor
        (
            ICharacterService characterService
        ){
            _characterService = characterService;
        }

        void Start(){
            _characterService.baseStatsAsObservable.Subscribe(
                _ => 
                    {
                        if(_ == null){
                            Text.text = "0/0";
                        } else {
                            Text.text = _.health + "/" + _.health;
                        }
                    }
            ).AddTo(this);
        }
    }
}
