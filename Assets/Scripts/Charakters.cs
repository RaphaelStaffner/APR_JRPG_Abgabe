using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Charakters 
{

    public static List<Charakters> Loc = new List<Charakters>();

    private string _name = "empty", _role = "empty";
    private int _exp, _expneeded, _HP, _currentHP, _MP, _currentMP, _attack, _defense, _magattack, _magdefense, _init, _baseHP, _baseMP, _baseattack, _basedefense, _basemagattack, _basemagdefense, _baseinit;
    private double _level;

    #region Getter & Setter
    public string CharacterName
    {
        get { return _name; }
        set { _name = value; }
    }
    public string role
    {
        get { return _role; }
        set { _role = value; }
    }

    public double level
    {
        get { return _level; }
        set { _level = value; }
    }
    public int exp
    {
        get { return _exp; }
        set { _exp = value; }
    }
    public int expneeded
    {
        get { return _expneeded; }
        set { _expneeded = value; }
    }
    public int HP
    {
        get { return _HP; }
        set { _HP = value; }
    }
    public int currentHP
    {
        get { return _currentHP; }
        set { _currentHP = value; }
    }
    public int MP
    {
        get { return _MP; }
        set { _MP = value; }
    }
    public int currentMP
    {
        get { return _currentMP; }
        set { _currentMP = value; }
    }
    public int attack
    {
        get { return _attack; }
        set { _attack = value; }
    }
    public int defense
    {
        get { return _defense; }
        set { _defense = value; }
    }
    public int magattack
    {
        get { return _magattack; }
        set { _magattack = value; }
    }
    public int magdefense
    {
        get { return _magdefense; }
        set { _magdefense = value; }
    }
    public int init
    {
        get { return _init; }
        set { _init = value; }
    }
    public int baseHP
    {
        get { return _baseHP; }
        set { _baseHP = value; }
    }
    public int baseMP
    {
        get { return _baseMP; }
        set { _baseMP = value; }
    }
    public int baseattack
    {
        get { return _baseattack; }
        set { _baseattack = value; }
    }
    public int basedefense
    {
        get { return _basedefense; }
        set { _basedefense = value; }
    }
    public int basemagattack
    {
        get { return _basemagattack; }
        set { _basemagattack = value; }
    }
    public int basemagdefense
    {
        get { return _basemagdefense; }
        set { _basemagdefense = value; }
    }
    public int baseinit
    {
        get { return _baseinit; }
        set { _baseinit = value; }
    }
    #endregion

    public Charakters() { }
    public Charakters(string name, string role, double level, int exp, int expneeded, int baseHP, int baseMP, int baseattack, int basedefense, int basemagattack, int basemagdefense, int baseinit)
    {
        this.CharacterName = name;
        this.role = role;
        this.level = level;
        this.exp = exp;
        this.expneeded = expneeded;
        this.baseHP = baseHP;
        this.baseMP = baseMP;
        this.baseattack = baseattack;
        this.basedefense = basedefense;
        this.basemagattack = basemagattack;
        this.basemagdefense = basemagdefense;
        this.baseinit = baseinit;

        HP = CalculateHP(this.baseHP, this.level);
        MP = CalculateMP(this.baseMP, this.level);
        currentHP = HP;
        currentMP = MP;
        attack = CalculateStats(this.baseattack, this.level);
        defense = CalculateStats(this.basedefense, this.level);
        magattack = CalculateStats(this.basemagattack, this.level);
        magdefense = CalculateStats(this.basemagdefense, this.level);
        init = CalculateStats(this.baseinit, this.level);
    }
    public Charakters(string name, string role, double level, int exp, int expneeded)
    {
        this.CharacterName = name;
        this.role = role;
        this.level = level;
        this.exp = exp;
        this.expneeded = expneeded;

        if (role.Equals("Knight"))
        {
            baseHP = 23;
            baseMP = 10;
            baseattack = 25;
            basedefense = 23;
            basemagattack = 12;
            basemagdefense = 15;
            baseinit = 12;
        }
        else if (role.Equals("Wizard"))
        {
            baseHP = 15;
            baseMP = 18;
            baseattack = 8;
            basedefense = 11;
            basemagattack = 28;
            basemagdefense = 24;
            baseinit = 16;
        }
        else if (role.Equals("Tank"))
        {
            baseHP = 32;
            baseMP = 8;
            baseattack =12;
            basedefense = 26;
            basemagattack = 12;
            basemagdefense = 26;
            baseinit = 4;
        }
        else if (role.Equals("Rogue"))
        {
            baseHP = 14;
            baseMP = 12;
            baseattack = 26;
            basedefense = 11;
            basemagattack = 26;
            basemagdefense = 11;
            baseinit = 20;
        }
        HP = CalculateHP(this.baseHP, this.level);
        MP = CalculateMP(this.baseMP, this.level);
        currentHP = HP;
        currentMP = MP;
        attack = CalculateStats(this.baseattack, this.level);
        defense = CalculateStats(this.basedefense, this.level);
        magattack = CalculateStats(this.basemagattack, this.level);
        magdefense = CalculateStats(this.basemagdefense, this.level);
        init = CalculateStats(this.baseinit, this.level);
    }

    public void CalculateStatsAfterwards()
    {
        HP = CalculateHP(this.baseHP, this.level);
        MP = CalculateMP(this.baseMP, this.level);
        currentHP = HP;
        currentMP = MP;
        attack = CalculateStats(this.baseattack, this.level);
        defense = CalculateStats(this.basedefense, this.level);
        magattack = CalculateStats(this.basemagattack, this.level);
        magdefense = CalculateStats(this.basemagdefense, this.level);
        init = CalculateStats(this.baseinit, this.level);
    }
    public void LevelUp()
    {
        level++;
        exp = exp - expneeded;

        //Method for calculating new "expneeded" is missing

        CalculateStatsAfterwards();
    }

    private int CalculateStats(int basestat, double level)
    {
        int stat;
        stat = Convert.ToInt32(Math.Round((basestat * (1 + (level / 2 * level) / 375) + level * 2) * 0.8));

        return stat;
    }

    private int CalculateMP(int baseMP, double level)
    {
        int mp;
        mp = Convert.ToInt32(Math.Round((baseMP * (1 + (level / 2 * level) / 500) + level * 2) * 0.8));

        return mp;
    }

    private int CalculateHP(int baseHP, double level)
    {
        int hp;
        hp = Convert.ToInt32(Math.Round((baseHP * (1 + (level / 2 * level) / 325) + level * 2) * 0.8));

        return hp;

    }
}

