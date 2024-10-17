using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstVariableAndMethod : MonoBehaviour
{
    public int currentAge = 24;
    public int ageIncrease = 1;
    bool isFunny = true; //or: false
    string myName = "Nicolai";
    //string myFirstName = "Nicolai";
    string mySecondName = "Andreas";
    public int a = 512;
    public int b = 731;
    int c;

    int d0 = 10;
    int d1 = 20;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("INITIAL VALUES: ");
        Debug.Log("a: " + a + " b: " + b + " c: " + c + " d0: " + d0 + " d1: " + d1);
    
    // Calls swap method for values a, b
        (a,b) = Swap(a,b);
    // Calls swap method for values d0, d1
        (d0, d1) = Swap (d0, d1);

        Debug.Log("NEW VALUES: ");
        Debug.Log("a: " + a + " b: " + b + " c: " + c + " d0: " + d0 + " d1: " + d1);

        (float f0, float f1) = Swap(1.5f, 7.3f);
        Debug.Log("f0: " + f0 + " f1: " + f1);

        (currentAge) IncreaseAge(currentAge);
        Debug.Log("Age: " + currentAge + agePostIncrease);
    }   

    /// <summary>
    /// Swaps two integer values with each other
    /// </summary>
    (int, int) Swap(int m, int n) {
            /*            
            c = m;
            m = n;
            n = c;
            */

            return(n, m);
        }

    /// <summary>
    /// Swaps two floating point values with each other
    /// </summary>
    (float, float) Swap(float m, float n) {
            /*
            c = m;
            m = n;
            n = c;
            */
            
            return(n, m);
        }

    /// <summary>
    /// aaAAA
    /// </summary>
    public static int IncreaseAge(int currentAge, int ageIncrease) {
        c = currentAge;
        currentAge++;

        //int agePostIncrease = c + ageIncrease;
        return (currentAge, ageIncrease);        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
