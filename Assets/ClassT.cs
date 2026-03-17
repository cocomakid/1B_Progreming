using UnityEngine;

public class ClassT : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Human man = new Human();
        man.name = "TEST";
        man.age = 22;
        man.height = 176;
        man.kg = 73;
        
        Human man2 = new Human();
        man2.name = "TEST2";
        man2.age = 20;
        man2.height = 167;
        man2.kg = 58;

        man.Attack(man2);

        Debug.Log(man2.Hp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public class Human
    {
        public string name;
        public float height;
        public float kg;
        public int age;

        public int Hp;
        public void Attack(Human target)
        {
            target.Hp = -5;
        }
    }

    
}
