using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerUpgrade
{

    public int Price { get; private set; }

    public int Damage { get; private set; }

    public float DebuffDuration { get; private set; }

    public float ProcChance { get; private set; }

    public float SlowingFactor { get; private set; }

    public float TickTime { get; private set; }

    public int SpecialDamage { get; private set; }

    public TowerUpgrade(int price, int damage, float debuffDuration, float procChance)
    {
        this.Damage = damage;
        this.DebuffDuration = debuffDuration;
        this.ProcChance = procChance;
        this.Price = price;
    }

    public TowerUpgrade(int price, int damage, float debuffDuration, float procChance, float slowingFactor)
    {
        this.Damage = damage;
        this.DebuffDuration = debuffDuration;
        this.ProcChance = procChance;
        this.SlowingFactor = slowingFactor;
        this.Price = price;
    }

    public TowerUpgrade(int price, int damage, float debuffDuration, float procChance, float tickTime, int specialDamage)
    {
        this.Damage = damage;
        this.DebuffDuration = debuffDuration;
        this.ProcChance = procChance;
        this.TickTime = tickTime;
        this.SpecialDamage = specialDamage;
        this.Price = price;
    }
}
