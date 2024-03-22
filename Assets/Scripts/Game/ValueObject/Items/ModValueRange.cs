using UnityEngine;
using System;

namespace Poecc.Game.ValueObject {
    [Serializable]
    public struct ModValueRange {
        public int min;
        public int max;
        public bool isCommon;
        public int chance;
        public int requiredItemLevel;
        }
}
