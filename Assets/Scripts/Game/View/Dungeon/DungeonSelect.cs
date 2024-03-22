using UnityEngine;
using Poecc.Game.IModel;
using VContainer;
using UnityEditor;
using R3;

namespace Poecc.Game.View {
    public class DungeonSelect : MonoBehaviour
    {
        private IDungeonService _dungeonService;
        [Inject]
        public void Constructor(
            IDungeonService dungeonService
        ){
            _dungeonService = dungeonService;
        }

        [SerializeField] private Transform _dungeonListRootTransform;
        [SerializeField] private GameObject _listItemPrefab;
        void Start(){
            _dungeonService.dungeonListAsObservable.Subscribe(dungeonList => {
                foreach(Transform child in _dungeonListRootTransform){
                    Destroy(child.gameObject);
                }
                if(dungeonList == null){
                    return;
                }
                foreach(var dungeon in dungeonList){    
                    GameObject obj = Instantiate(_listItemPrefab, _dungeonListRootTransform);
                    obj.transform.localScale = Vector3.one;
                    obj.GetComponent<DungeonItem>().setDungeonObject(dungeon);
                }
            }).AddTo(this);
        }
    }
}