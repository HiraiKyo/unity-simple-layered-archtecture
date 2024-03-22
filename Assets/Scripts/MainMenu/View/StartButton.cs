using UnityEngine;

using Poecc.IModel;
using Poecc.Entity;
using VContainer;

namespace Poecc.MainMenu.View {
    public class StartButton : MonoBehaviour
    {
        private ISavedataService _savedataService;

        [Inject]
        public void Constructor(
            ISavedataService savedataService
        ){
            _savedataService = savedataService;
        }
        public void OnClick() {
            // TODO: ゲームを開始する
            // 1. セーブデータを参照する
            UserEntity user = new UserEntity();
            _savedataService.LoadSavedata(user);
            // 2. セーブデータがあればそれを読み込む、なければ新規作成する
            // 3. ゲーム画面に移動する
            Debug.Log("シーン移動");
        }
    }
}
