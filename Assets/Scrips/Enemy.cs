using UnityEngine;
using System.Collections;
using System;

public class Enemy : IComparable<Enemy> {

    string name;
    uint powerlvl;

    public Enemy(string _name, uint _pLvl) {
        name = _name;
        powerlvl = _pLvl;
    }

    public int CompareTo(Enemy other) {
        return other.powerlvl.CompareTo(this.powerlvl);
    }

}