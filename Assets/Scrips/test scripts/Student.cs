using UnityEngine;
using System.Collections;

public enum Gender {
    Male,
    Female
}

public class Student {
    string name;
    uint age;

    private Gender gender;

    public Student(string _name, uint _age, Gender _gender) {
        name    = _name;
        age     = _age;
        gender  = _gender;
    }
}
