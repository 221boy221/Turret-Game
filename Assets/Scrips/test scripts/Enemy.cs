using UnityEngine;
using System.Collections;

public enum EnemyType {
    Strong,
    Weak
}

public class Enemy {
    string name;
    uint hp;
    uint dmg;
    float speed;

    private EnemyType enemyType;

    public Enemy(string _name, EnemyType _type, uint _hp, uint _dmg, float _speed) {
        name        = _name;
        enemyType   = _type;
        hp          = _hp;
        dmg         = _dmg;
        speed       = _speed;
    }
}
