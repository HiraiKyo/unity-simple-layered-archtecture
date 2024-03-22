using R3;
using ObservableCollections;
using Poecc.Entity;
namespace Poecc.IModel {
  public interface ISettingService {
    ReadOnlyReactiveProperty<string> version { get; }
    Observable<string> versionAsObservable { get; }
  }
}