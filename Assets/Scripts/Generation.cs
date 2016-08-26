using UnityEngine;
using System.Collections.Generic;

public class Generation : MonoBehaviour {

    public GameObject temp;
    public GameObject start;
    private List<GameObject> path = new List<GameObject>();
    public int count;

	// Use this for initialization
	void Start () {
        path.Add(start);
        for (int i = 0; i < count; i++)
        {
            int rand = Random.Range(1, 5);

            switch (rand)
            {
                case 1:
                    {
                        GameObject holder = Instantiate(temp, new Vector3(path[path.Count -1 ].transform.position.x, 0, path[path.Count-1 ].transform.position.z - 1), Quaternion.identity) as GameObject;
                        path.Add(holder);
                        break;
                    }
                case 2:
                    {
                        GameObject holder1 = Instantiate(temp, new Vector3(path[path.Count-1 ].transform.position.x +1 , 0, path[path.Count-1 ].transform.position.z), Quaternion.identity) as GameObject;
                        path.Add(holder1);
                        break;
                    }
                case 3:
                    {
                        GameObject holder2 = Instantiate(temp, new Vector3(path[path.Count-1 ].transform.position.x, 0, path[path.Count-1 ].transform.position.z+1), Quaternion.identity) as GameObject;
                        path.Add(holder2);
                        break;
                    }
                case 4:
                    {
                        GameObject holder3 = Instantiate(temp, new Vector3(path[path.Count-1 ].transform.position.x - 1, 0, path[path.Count-1 ].transform.position.z), Quaternion.identity) as GameObject;
                        path.Add(holder3);
                        break;
                    }

                default:
                    break;
            }

        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
