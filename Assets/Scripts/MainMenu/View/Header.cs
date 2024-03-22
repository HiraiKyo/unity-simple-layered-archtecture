using Poecc.IModel;
using R3;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VContainer;
namespace Poecc.MainMenu.View {
  public class Header : MonoBehaviour {
    private ISettingService _settingService;
    [SerializeField] public TextMeshProUGUI Text;

    [Inject]
    public void Constructor(
      ISettingService settingService
    ){
      _settingService = settingService;
    }
    void Start(){
      _settingService.versionAsObservable.Subscribe(
        _ => Text.text = "Version: " + _
      ).AddTo(this);
    }
  }
}