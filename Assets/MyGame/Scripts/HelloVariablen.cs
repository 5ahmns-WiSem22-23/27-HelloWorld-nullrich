using UnityEngine;

public class HelloVariablen : MonoBehaviour
{

    int myInt = 0;
    bool myBool = true;

    string myString = "Hallo";

    int[] myArray = new int[] { 0, 0, 0 };

    private void Start()
    {
        Debug.Log(sizeof(int));
        Debug.Log(sizeof(bool));

        int tempInt = myInt;
        myInt++;
        Debug.Log("myInt: " + myInt + " temp: " + tempInt);

        int[] tempArray = myArray;
        myArray[0] = 1;
        myArray[1] = 2;
        myArray[2] = 3;

        foreach (int a in tempArray)
        {
            Debug.Log(a);
        }

        foreach (int a in myArray)
        {
            Debug.Log(a);
        }

        string tempString = myString;
        myString = "Hello";
        Debug.Log("myString: " + myString + " tempString: " + tempString);
    }
}
