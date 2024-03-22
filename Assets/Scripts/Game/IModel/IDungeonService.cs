using System.Collections.Generic;
using Poecc.Game.ValueObject;
using R3;
using UnityEngine.UIElements;

namespace Poecc.Game.IModel {
  public interface IDungeonService {
    /// <summary>
    /// 選択中のダンジョン侵攻を開始
    /// </summary>
    public void startDungeon();
    /// <summary>
    /// 侵攻中のダンジョンを途中離脱
    /// </summary>
    public void cancelDungeon();

    /// <summary>
    /// ダンジョンリスト
    /// </summary>
    /// <value></value>
    ReadOnlyReactiveProperty<List<DungeonObject>> dungeonList {get; }
    /// <summary>
    /// ダンジョンリストイベントリスナー
    /// </summary>
    /// <value></value>
    Observable<List<DungeonObject>> dungeonListAsObservable { get; }
    /// <summary>
    /// ダンジョン一覧を設定
    /// </summary>
    /// <param name="dungeonList"></param>
    public void setDungeonList(List<DungeonObject> dungeonList);
    /// <summary>
    /// 選択中のダンジョン
    /// </summary>
    /// <value></value>
    ReadOnlyReactiveProperty<DungeonObject> dungeon { get; }
    /// <summary>
    /// 選択中のダンジョンを購読
    /// </summary>
    /// <value></value>
    Observable<DungeonObject> dungeonAsObservable { get; }
    /// <summary>
    /// ダンジョンを選択
    /// </summary>
    /// <param name="dungeon"></param>
    public void selectDungeon(DungeonObject dungeon);

    /// <summary>
    /// ダンジョン侵攻ステータス
    /// </summary>
    /// <value></value>
    ReadOnlyReactiveProperty<InvasingStatus> status { get; }
    /// <summary>
    /// ダンジョン侵攻ステータスリスナー
    /// </summary>
    /// <value></value>
    Observable<InvasingStatus> statusAsObservable { get; }
    /// <summary>
    /// ダンジョン侵攻ステータスを設定
    /// </summary>
    /// <param name="status"></param>
    public void setInvasing(InvasingStatus status);

    /// <summary>
    /// 直近のダンジョン結果報酬
    /// </summary>
    /// <value></value>
    public RewardObject lastReward { get; }
  }
  public enum InvasingStatus {
    Available = 0,
    Invasing = 1,
    Finished = 2,
    Failed = 3,
  }
}