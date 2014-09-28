using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DynamicTargetting : MonoBehaviour {
    private List<Student2> students = new List<Student2>();

	// Use this for initialization
	void Start () {
	    Student2 studentOne = new Student2("Piet", 10);
	    Student2 studentTwo = new Student2("Klaas", 50);
	    Student2 studentThree = new Student2("Daisy", 800);

        students.Add(studentOne);
        students.Add(studentTwo);
        students.Add(studentThree);
        //print(students);
        students.Sort();
        print(students);
	}
    
}
