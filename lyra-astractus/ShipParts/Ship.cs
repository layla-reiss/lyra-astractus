namespace ConsoleApp1.GeneralClasses;

public class Ship
{
    private string shipType;
    internal int xAllowedSpace;
    internal int yAllowedSpace;
    internal int weaponSlots;
    private string weight;
    internal int engineNumber;
    private boolean jumpDrive;
    private boolean isFreighter;

    public Ship(string shipType, boolean isFreighter)
    {
        this.shipType = shipType;
        switch (shipType)
        {
            case "corvet":
                corvet();
                break;
            case "mediumFighter":
                mediumFighter();
                break;
            case "largeFighter":
                largeFighter();
                break;
            case "frigate":
                frigate();
                break;
            case "destroyer":
                destroyer();
                break;
            case "cruiser":
                cruiser();
                break;
            case "spaceCraftCarrier":
                spaceCraftCarrier();
                break;
        }
    }
    //dwarf fighter are npcs to be added later
    //smaller than medium fighter, lighter than medium fighter
    private void mediumFighter()
    {
        this.xAllowedSpace = 30;
        this.yAllowedSpace = 30;
        this.weaponSlots = 2;
        this.weight = "light";
        this.engineNumber = 1;
        this.jumpDrive = true;
        
    }
    private void largeFighter()
    {
        this.xAllowedSpace = 35;
        this.yAllowedSpace = 35;
        this.weaponSlots = 2;
        this.weight = "light";
        this.engineNumber = 1;
        this.jumpDrive = true;
    }
    private void corvet()
        {
            this.xAllowedSpace = 40;
            this.yAllowedSpace = 40;
            this.weaponSlots = 4;
            this.weight = "mediumLight";
            this.engineNumber = 1;
            this.jumpDrive = true;
        }
    
    private void frigate() 
    {
        this.xAllowedSpace = 100;
        this.yAllowedSpace = 200;
        this.weaponSlots = 6;
        this.weight = "medium";
        this.engineNumber = 2;
        this.jumpDrive = true;
    }    
    //anything bigger can't land at regular spaceports
    
    private void destroyer()
    {
        this.xAllowedSpace = 200;
        this.yAllowedSpace = 200;
        this.weaponSlots = 6;
        this.weight = "mediumHeavy"
        this.engineNumber = 2;
        this.jumpDrive = true;
    }
    
    private void cruiser()
    {
        this.xAllowedSpace = 200;
        this.yAllowedSpace = 400;
        this.weaponSlots = 6;
        this.weight = "mediumHeavy";
        this.engineNumber = 2;
        this.jumpDrive = true;
    }
    
    private void spaceCraftCarrier()
    {
        this.xAllowedSpace = 500;
        this.yAllowedSpace = 500;
        this.weaponSlots = 6;
        this.weight = "heavy";
        this.engineNumber = 2;
        this.jumpDrive = true;
    }
    //absolute maximum
}