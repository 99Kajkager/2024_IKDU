using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeeklyScheduleArray : MonoBehaviour
{
    string[] Weekdays = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

    public float updateInterval = 1.0f; // updatetime interval
    
    // Coroutine to increment days with a longer interval
    IEnumerator UpdateDayArray() {
            for (int day = 0; day < Weekdays.Length; day++) {
                if (Weekdays[day] == "Monday") {
                    Debug.Log ("It's horrible... It's " + Weekdays[day] + ".");
                } else if (Weekdays[day] == "Tuesday") {
                    Debug.Log ("It's " + Weekdays[day] + "... At least it's not Monday.");
                } else if (Weekdays[day] == "Wednesday") {
                    Debug.Log ("It's " + Weekdays[day] + " my dudes!");
                } else if (Weekdays[day] == "Thursday") {
                    Debug.Log ("It's " + Weekdays[day] + ". Otherwise known as little Friday!");
                } else if (Weekdays[day] == "Friday") {
                    Debug.Log ("It's " + Weekdays[day] + "! Time to party!");
                } else if (Weekdays[day] == "Saturday") {
                    Debug.Log ("I feel the freedom. It's " + Weekdays[day]);
                } else {
                    Debug.Log ("It's " + Weekdays[day] + ". I am afraid because it's Monday tomorrow.");
                    day = -1;
                }

                // Delay
                yield return new WaitForSeconds(updateInterval);
            }        
    }
     
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(UpdateDayArray());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
