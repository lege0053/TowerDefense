using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TowerFactory
{
    public static List<Tower> Towers { get; set; } = new List<Tower>();
    
    public static Tower CreateTower(Element typeElement)
    {
        Tower t = null; 

        switch (typeElement)
        {
            case Element.FIRE:
                t = new FireTower();
                break;
            case Element.STORM:
                t = new StormTower();
                break;
            case Element.FROST:
                t = new FrostTower();
                break;
            case Element.POISON:
                t = new PoisonTower();
                break;
            default:
                break;
        }
        
        if (t != null)
            Towers.Add(t); 
        return t;
    }

    public static Tower CreateTower<T>() where T : Tower
    {
        Tower t = Activator.CreateInstance<T>();
        Towers.Add(t); 
        return t; 
    }
}