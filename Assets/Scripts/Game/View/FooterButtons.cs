using R3;
using UnityEngine;
using UnityEngine.UI;

namespace Poecc.Game.View {
    public class FooterButtons : MonoBehaviour
    {
        [SerializeField] private Button _characterButton;
        [SerializeField] private Button _inventoryButton;
        [SerializeField] private Button _dungeonButton;
        [SerializeField] private Button _settingButton;

        [SerializeField] private PageSwiper _pageSwiper;

        void Start(){
            _characterButton.OnClickAsObservable().Subscribe(_ => _pageSwiper.switchPage(1)).AddTo(this);
            _inventoryButton.OnClickAsObservable().Subscribe(_ => _pageSwiper.switchPage(2)).AddTo(this);
            _dungeonButton.OnClickAsObservable().Subscribe(_ => _pageSwiper.switchPage(3)).AddTo(this);
            _settingButton.OnClickAsObservable().Subscribe(_ => _pageSwiper.switchPage(4)).AddTo(this);
        }
    }
}
