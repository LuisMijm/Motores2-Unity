
public class Character
{
    public float attack_;
    public float deffence_;
    public float health_;  
    public float charisma_;
    public float intelect_;
    public int level_; 
    public int alignment_;
    public int gold_;
    public bool magic_;
    public bool caster_;

    public Character(float att = 0.0f, bool magic = false, float def = 0.0f, float health = 0.0f) 
    {
        attack_ = att;
        deffence_ = def;
        magic_ = magic;
        health_ = health;
        // deffence_ = 100.0f;
    }
}
