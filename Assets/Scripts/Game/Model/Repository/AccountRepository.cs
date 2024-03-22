using Poecc.Game.IModel;
using VContainer;
using System.IO;
using UnityEngine;
using System.Threading.Tasks;
using Poecc.Model;

namespace Poecc.Game.Repository {
    public class AccountRepository
    {   
        private ICharacterService _characterService;
        private IDungeonService _dungeonService;
        private IInventoryService _inventoryService;
        private ISettingService _settingService;

        [Inject]
        public AccountRepository (
            ICharacterService characterService,
            IDungeonService dungeonService,
            IInventoryService inventoryService,
            ISettingService settingService
        ){
            _characterService = characterService;
            _dungeonService = dungeonService;
            _inventoryService = inventoryService;
            _settingService = settingService;
        }

        private string savefilePath;
        private string savefileName = "Savedata.json";

        public async void LoadAccount(){
            // 1. アカウントデータを読み込む
            savefilePath = Application.dataPath + "/" + savefileName;
            if(!File.Exists(savefilePath)){
                await CreateAccount();
            }
            StreamReader rd = new StreamReader(savefilePath);
            string json = rd.ReadToEnd();
            rd.Close();
                                                                    
            var savedata = JsonUtility.FromJson<SaveData>(json);
            // 2. TODO: キャラクターデータ、インベントリ、ダンジョン進捗、設定の読込
            
        }
        public async void SaveAccount(){            
            // 1. TODO: キャラクターデータ、インベントリ、ダンジョン進捗、設定をJSON加工する
            
            // 2. アカウントデータとして書き出す
            SaveData data = new SaveData();
            string json = JsonUtility.ToJson(data);

            StreamWriter wr = new StreamWriter(savefilePath, false);
            wr.WriteLine(json);
            wr.Close();
        }
        public async Task CreateAccount(){
            SaveData data = new SaveData();
            string json = JsonUtility.ToJson(data);

            StreamWriter wr = new StreamWriter(savefilePath, false);
            wr.WriteLine(json);
            wr.Close();
        }
    }
}
