using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeeklySchedule : MonoBehaviour
{
    public int day;
    public float updateInterval = 3.0f; // updatetime interval
    
    // Coroutine to increment days with a longer interval
    IEnumerator UpdateDay() {
        while (true) {
            day++;

            if (day > 7) {
                day = 0;
            }

            // Console logs switch case for each day
            switch(day) {
            case 1:
                Debug.Log("Monday");
                Debug.Log("I am very sad now");
                break;
            case 2:
                Debug.Log("Tuesday");
                Debug.Log("More like chewsday");
                break;
            case 3:
                Debug.Log("Wednesday");
                Debug.Log("It is Wednesday my dudes");
                break;
            case 4:
                Debug.Log("Thursday");
                Debug.Log("Thursday AKA Pubcrawl day");
                break;
            case 5:
                Debug.Log("Friday");
                Debug.Log("Friday Friday, gotta get down on Friday");
                break;
            case 6:
                Debug.Log("Saturday");
                Debug.Log("It's Saturday and I will sleep all day");
                break;
            case 7:
                Debug.Log("Sunday");
                Debug.Log("Sunday, I am dreading that Monday is tomorrow");
                break;

            }

            // Delay
            yield return new WaitForSeconds(updateInterval);
        }
    }
    
    // Start is called before the first frame update
    void Start() {
        StartCoroutine(UpdateDay());
    } 
}
