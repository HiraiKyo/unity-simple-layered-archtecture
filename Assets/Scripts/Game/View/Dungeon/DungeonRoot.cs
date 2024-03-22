using System.Collections;
using System.Collections.Generic;
using Poecc.Game.IModel;
using R3;
using UnityEngine;
using VContainer;

namespace Poecc.Game.View{
    public class DungeonRoot : MonoBehaviour
    {
        private IDungeonService _dungeonService;
        [Inject]
        public void Constructor(
            IDungeonService dungeonService
        ){
            _dungeonService = dungeonService;
        }
        
        [SerializeField] public GameObject selectRoot;
        [SerializeField] public GameObject invasingRoot;
        [SerializeField] public GameObject finishedRoot;
        [SerializeField] public GameObject failedRoot;

        void Start(){
            _dungeonService.statusAsObservable.Subscribe(activeWindow).AddTo(this);
        }

        private void activeWindow(InvasingStatus status){
            switch(status){
                case InvasingStatus.Available:
                    selectRoot.SetActive(true);
                    invasingRoot.SetActive(false);
                    finishedRoot.SetActive(false);
                    failedRoot.SetActive(false);
                    break;
                case InvasingStatus.Invasing:
                    selectRoot.SetActive(false);
                    invasingRoot.SetActive(true);
                    finishedRoot.SetActive(false);
                    failedRoot.SetActive(false);
                    break;
                case InvasingStatus.Finished:
                    selectRoot.SetActive(false);
                    invasingRoot.SetActive(false);
                    finishedRoot.SetActive(true);
                    failedRoot.SetActive(false);
                    break;
                case InvasingStatus.Failed:
                    selectRoot.SetActive(false);
                    invasingRoot.SetActive(false);
                    finishedRoot.SetActive(false);
                    failedRoot.SetActive(true);
                    break;
                default:
                    selectRoot.SetActive(true);
                    invasingRoot.SetActive(false);
                    finishedRoot.SetActive(false);
                    failedRoot.SetActive(false);
                    break;
            }
        }
    }
}
