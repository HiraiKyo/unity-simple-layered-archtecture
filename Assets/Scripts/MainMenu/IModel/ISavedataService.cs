using Poecc.Entity;

namespace Poecc.IModel {
  public interface ISavedataService {
    /// 
    /// セーブデータを読み込む関数
    ///
    public bool LoadSavedata(UserEntity user);
    ///
    /// 新規にゲームを始める場合の関数
    ///
    public bool CreateNew();
  }
}