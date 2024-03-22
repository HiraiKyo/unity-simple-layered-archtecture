namespace Poecc.Game.ValueObject {
  public class CharStatsObject {
    public int health;
    public int mana; 

    // 攻撃関連
    public int inc_attack_damage;
    public float attack_speed;
    public int inc_attack_speed;

    // 魔法関連
    public int inc_spell_damage;
    public float cast_speed;
    public int inc_cast_speed;

    // 属性関連
    public int add_fire_attack_damage;
    public int add_fire_spell_damage;
    public int inc_fire_damage;
    public int add_cold_attack_damage;
    public int add_cold_spell_damage;
    public int inc_cold_damage;
    public int add_lightning_attack_damage;
    public int add_lightning_spell_damage;
    public int inc_lightning_damage;
    public int add_physical_attack_damage;
    public int add_physical_spell_damage;
    public int inc_physical_damage;
    public int add_chaos_attack_damage;
    public int add_chaos_spell_damage;
    public int inc_chaos_damage;

    // 防御関連
    public int armour;
    public int evasion;
    public int block;

    // 耐性関連
    public int physical_resistance;
    public int fire_resistance;
    public int cold_resistance;
    public int lightning_resistance;
    public int chaos_resistance;
  }
}