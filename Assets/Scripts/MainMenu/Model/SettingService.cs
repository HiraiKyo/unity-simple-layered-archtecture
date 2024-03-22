using Poecc.IModel;
using R3;

namespace Poecc.Model {
    public class SettingService : ISettingService
    {
        private ReactiveProperty<string> _version = new ReactiveProperty<string>("0.0.0");
        public ReadOnlyReactiveProperty<string> version => _version;
        public Observable<string> versionAsObservable => _version;
    }
}