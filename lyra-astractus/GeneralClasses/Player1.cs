namespace ConsoleApp1.GeneralClasses;

public class Player1
{
    internal int maxHealth;
    internal int remainingHealth;
    private quest[] questLog { get; private set; }; //TODO make quest class
    private skill[] skillList { get; private set; }; //TODO make skill class
    private posession[] inventory { get; private set; }; //TODO make posession class
 //TODO method for freezing
    //TODO method for suffocation
    //TODO method for overheating
    //TODO method for taking damage
    public Player1(int maxHealth, int remainingHealth, quest[] questLog, skill[] skillList, posession[] inventory)
    {
        this.maxHealth = maxHealth;
        this.remainingHealth = remainingHealth;
        this.questLog = questLog;
        this.skillList = skillList;
        this.inventory = inventory;
    }
    
    
}