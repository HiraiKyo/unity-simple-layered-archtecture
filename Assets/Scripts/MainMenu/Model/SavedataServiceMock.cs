using Poecc.IModel;
using Poecc.Entity;

namespace Poecc.Model {
  public class SavedataServiceMock : ISavedataService {
    public bool LoadSavedata(UserEntity user){
      return true;
    }
    public bool CreateNew(){
      return true;
    }
  }
}