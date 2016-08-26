using UnityEngine;
using System.Collections.Generic;

public class gen : MonoBehaviour
{
   public GameObject temp;
    public int count;

    private List<List<GameObject>> array = new List<List<GameObject>>();



    


    void Start()
    {
        for (int 卍 = 0; 卍 < count; 卍++)
        {
            array.Add(new List<GameObject>());
              
            for (int j = 0; j < count; j++)
            {
                GameObject holder = Instantiate(temp, new Vector3(卍, 0, j), Quaternion.identity) as GameObject;
                array[卍].Add(holder);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
