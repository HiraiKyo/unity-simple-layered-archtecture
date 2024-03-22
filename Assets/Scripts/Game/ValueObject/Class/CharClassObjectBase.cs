using UnityEngine;

namespace Poecc.Game.ValueObject {
  [CreateAssetMenu(fileName = "Class_", menuName = "ScriptableObjects/Class", order = 1)]
  public class CharClassObjectBase : ScriptableObject {
    public CharStatsObject baseClassStats = new CharStatsObject();
    public CharClassObjectBase(){
      baseClassStats.health = 100;
      baseClassStats.mana = 50;
    }
  }
}