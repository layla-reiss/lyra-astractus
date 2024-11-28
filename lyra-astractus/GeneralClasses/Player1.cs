namespace DefaultNamespace;

public class Player1
{
    internal int maxHealth { get; private set; }
    internal int remainingHealth {get; private set;}
    private Quest[] questLog { get; private set; } //TODO make quest class
    private Skill[] skillList { get; private set; } //TODO make skill class
    private Posession[] inventory { get; private set; } //TODO make posession class
 //TODO method for freezing
    //TODO method for suffocation
    //TODO method for overheating
    //TODO method for taking damage
    public Player1(int maxHealth, int remainingHealth, Quest[] questLog, Skill[] skillList, Posession[] inventory)
    {
        this.maxHealth = maxHealth;
        this.remainingHealth = remainingHealth;
        this.questLog = questLog;
        this.skillList = skillList;
        this.inventory = inventory;
    }

    public void takeDamage(int damage)
    {
        setRemainingHealth(this.remainingHealth - damage);
    }
    
}