using UnityEngine;

public class Test0310 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        // 더하기와 빼기가 둘다 작동하는 함수
        // 인자값을 통해서 더하기를 할지 마이너스를 할지 결정할 수 있음
        // bool = true, false

        //정수 //
        //실수 //
        //

        int age = 0;
        float height = 174.2f;
        string name = "ㅎㅇ";
        bool isMale = false;

        age = 22;
        height = 176.6f;
        name = "이름";
        isMale = true;

        age = age + 1;
        age = age - 1;
        age = age * 2;
        age = age / 2;

        //
        int number = 100;
        number += 10;
        number /= 30;

        int firstNumber = Plus(10, 20);

        Debug.Log(Plus(10, 10));

        int hp = 100;

        if (hp < 0)
        {
            //hp <= 0;
            //Debug.Log("Die");
        }
        else
        {
            //hp > 0;
            //Debug.Log("Survive");
        }

    }
    //void Function(int left, int right)
    //{
    //    // 로직

    //    return 0;
    //}

    int Positive(int a, int b)
    {
        if (a < b)
        {
            return a + b;

        }
        else
        {
            return a - b;

        }

    }
    
    int Negative(int a, int b)
    {
        if (a > b)
        {
            return a + b;

        }
        else
        {
            return a - b;

        }

    }
    

    int Dobule(int a, int b, bool tru)
    {
        if (tru)
        {
            return a + b;

        }
        else
        {
            return a - b;

        }

    }

    int GetBigger(int left, int right)
    {
        if(left > right)
        {
            return left;
        }
        else
        {
            return right;
        }

    }

    int Plus(int left, int right)
    {
        return left + right;
    }

    int Minus(int left, int right)
    {
        return left - right;
    }
    
    int Divide(int left, int right)
    {
        return left / right;
    }

    int Multiplication (int left, int right)
    {
        return left * right;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
