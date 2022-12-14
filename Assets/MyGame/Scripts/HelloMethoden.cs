using UnityEngine;

public class HelloMethoden : MonoBehaviour
{
    
    private int startValue = 0;

    
    private int startValue3 = 0;

    
    private int startValue4 = 0;


    private int startValue5 = 0;


    void Start()
    {
        
        Debug.Log("Hallo Methoden");

        
        Debug.Log("before startValue: " + startValue);
        IncrementByOne();
        Debug.Log("after startValue: " + startValue);

        
        Debug.Log("before startValue3: " + startValue);
        IncrementBy(Random.Range(1, 10));
        Debug.Log("after startValue3: " + startValue);


        Debug.Log("before startValue4: " + startValue4);
        DecrementByOne(startValue4);
        Debug.Log("after startValue4: " + startValue4);


        Debug.Log("before startValue5: " + startValue5);
        startValue5 = DecrementByX(startValue5, 2);
        Debug.Log("after  startValue5: " + startValue5);
    }


    private int DecrementByX(int start, int valToSub)
    {
        return start - valToSub;
    }

    private void DecrementByOne(int val)
    {
        val--;
        Debug.Log("val: " + val);
    }

    private void IncrementBy(int valToAdd)
    {
        startValue3 += Mathf.Abs(valToAdd);
    }

    private void IncrementByOne()
    {
        startValue++;
    }
}
