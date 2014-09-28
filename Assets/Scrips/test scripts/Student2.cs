using UnityEngine;
using System.Collections;
using System;

public class Student2 : IComparable<Student2> {

    string name;
    uint powerlvl;

    public Student2(string _name, uint _pLvl) {
        name        = _name;
        powerlvl    = _pLvl;
    }

    public int CompareTo(Student2 other) {
        return other.powerlvl.CompareTo(this.powerlvl);
    }

}