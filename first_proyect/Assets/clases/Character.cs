
public class Character
{
    private float attack_;
    private float deffence_;
    private float health_;  
    private float charisma_;
    private float intelect_;
    private int level_; 
    private int alignment_;
    private int gold_;
    private bool magic_;
    private bool caster_;

    public Character(float att, float magic, float def, float health) 
    {
        attack_ = att;
        deffence_ = def;
        magic_ = magic;
        health_ = health;
        deffence_ = 100.0f;
    }
}
