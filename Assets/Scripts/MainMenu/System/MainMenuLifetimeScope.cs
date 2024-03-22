using Poecc.IModel;
using Poecc.Model;
using VContainer;
using VContainer.Unity;

namespace Poecc.MainMenu.System {
    public class MainMenuLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder){
            // ここで依存関係を構築する
            builder.Register<ISavedataService, SavedataServiceMock>(Lifetime.Singleton);
            builder.Register<ISettingService, SettingService>(Lifetime.Singleton);
        }
    }
}