using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DictionaryScript : MonoBehaviour {

    private Dictionary<string, List<Student>> grade = new Dictionary<string, List<Student>>();

    private Dictionary<EnemyType, List<Enemy>> enemyDic = new Dictionary<EnemyType, List<Enemy>>();

	// Use this for initialization
	void Start () {
        Enemy enemy01 = new Enemy("EnemyName01", EnemyType.Strong, 10, 5, 10);

        List<Enemy> enemyList = new List<Enemy>();
        enemyList.Add(enemy01);
	}

    void StudentStuff() {
        Student student = new Student("Boy", 17, Gender.Male);
        Student student2 = new Student("Justin", 18, Gender.Male);

        List<Student> studentList = new List<Student>();
        studentList.Add(student);
        studentList.Add(student2);

        grade.Add("GD2", studentList);

        Debug.Log(grade);
    }
	
}
