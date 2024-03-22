using System.Collections.Generic;
using Poecc.Game.IModel;
using Poecc.Game.ValueObject;
using R3;
using VContainer;

namespace Poecc.Game.Model {
    public class DungeonService : IDungeonService
    {
        private IInventoryService _inventoryService;
        [Inject]
        public DungeonService(
          IInventoryService inventoryService
        ){
          _inventoryService = inventoryService;
        }

        private ReactiveProperty<DungeonObject> _dungeon = new ReactiveProperty<DungeonObject>(null);
        public ReadOnlyReactiveProperty<DungeonObject> dungeon => _dungeon;

        public Observable<DungeonObject> dungeonAsObservable => _dungeon;

        public void selectDungeon(DungeonObject dng)
        {
            // 1. TODO: このダンジョンが選択可能か判定する

            // 2. ダンジョンを選択する
            _dungeon.OnNext(dng);
        }

        public void startDungeon()
        {
            // 1. TODO: 選択中のダンジョンを開始可能か判定する

            // 2. TODO: ダンジョン開始の確認ウィンドウを表示する

            // 3. TODO: ダンジョン侵攻中ステータスに変更する
            setInvasing(InvasingStatus.Invasing);
        }
        public void cancelDungeon(){
          // 1. TODO: 侵攻中のダンジョンをキャンセル可能か判定する

          // 2. TODO: ダンジョン途中離脱の確認ウィンドウを表示する

          // 3. TODO: ダンジョン失敗ステータスに変更する
          setInvasing(InvasingStatus.Failed);
        }

        private ReactiveProperty<InvasingStatus> _status = new ReactiveProperty<InvasingStatus>(InvasingStatus.Available);
        public ReadOnlyReactiveProperty<InvasingStatus> status => _status;

        public Observable<InvasingStatus> statusAsObservable => _status;
        public void setInvasing(InvasingStatus status){
          // TODO: ステータス変更の制限ロジックを作る

          // TODO: 侵攻が完了したら、報酬をインベントリに格納し報酬内容を送信する
          if(status == InvasingStatus.Finished){
            // 報酬経験値処理
            var exp = _dungeon.Value.calDungeonRewardExperience();
            // TODO: 経験値をキャラクターに反映

            // 報酬アイテム処理
            var itemList = _dungeon.Value.calDungeonRewardItems();
            foreach (var item in itemList){
              _inventoryService.addItem(item);
            }

            // リザルト画面用に報酬内容を保持
            _lastReward = new RewardObject(exp, itemList);
          }
          _status.OnNext(status);
        }
        private RewardObject _lastReward;
        public RewardObject lastReward => _lastReward;

        private ReactiveProperty<List<DungeonObject>> _dungeonList = new ReactiveProperty<List<DungeonObject>>();
        public ReadOnlyReactiveProperty<List<DungeonObject>> dungeonList => _dungeonList;

        public Observable<List<DungeonObject>> dungeonListAsObservable => _dungeonList;
        public void setDungeonList(List<DungeonObject> list)
        {
            _dungeonList.OnNext(list);
        }

    }
}
