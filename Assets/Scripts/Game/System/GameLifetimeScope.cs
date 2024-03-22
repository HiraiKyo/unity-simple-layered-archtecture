using Poecc.Game.IModel;
using Poecc.Game.Model;
using VContainer;
using VContainer.Unity;

namespace Poecc.Game.System {
    public class GameLifetimeScope : LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder){
            // ここで依存関係を構築する
            builder.Register<ICharacterService, CharacterService>(Lifetime.Singleton);
            builder.Register<IInventoryService, InventoryService>(Lifetime.Singleton);
            builder.Register<IDungeonService, DungeonService>(Lifetime.Singleton);
            builder.Register<ISettingService, SettingService>(Lifetime.Singleton);
            builder.Register<IItemizeService, ItemizeService>(Lifetime.Singleton);
            builder.Register<IItemizeModel, ItemizeModel>(Lifetime.Singleton);
        }
    }
}