using UnityEngine;
using System.Collections.Generic;



public class Generation : MonoBehaviour {

    public GameObject temp;
    public GameObject start;
    private List<GameObject> path = new List<GameObject>();
    public int count;
    public float jiggle;
    public float moveJiggle;

    void fix(GameObject placing)
    {
        
        for(int i = 0; i < path.Count; i ++)
        {
            if (placing.transform.position == path[i].transform.position)
            {
                placing.transform.position += new Vector3(0, 1, 0);
            }
        }
    }
	// Use this for initialization
	void Start () {
        path.Add(start);
        for (int i = 0; i < count; i++)
        {
            Vector3 pos = path[path.Count - 1].transform.position;
            int rand = Random.Range(1, 5);
            int offset = 1;


            switch (rand)
            {
                case 1:
                    {
                        GameObject holder = Instantiate(temp, new Vector3(path[path.Count -1 ].transform.position.x, 0, path[path.Count-1 ].transform.position.z - offset), Quaternion.identity) as GameObject;
                        fix(holder);
                        path.Add(holder);
                        break;
                    }
                case 2:
                    {
                        GameObject holder1 = Instantiate(temp, new Vector3(path[path.Count-1 ].transform.position.x  +offset , 0, path[path.Count-1 ].transform.position.z), Quaternion.identity) as GameObject;
                        fix(holder1);
                        path.Add(holder1);
                        break;
                    }
                case 3:
                    {
                        GameObject holder2 = Instantiate(temp, new Vector3(path[path.Count-1 ].transform.position.x, 0, path[path.Count-1 ].transform.position.z  +offset), Quaternion.identity) as GameObject;
                        fix(holder2);
                        path.Add(holder2);
                        break;
                    }
                case 4:
                    {
                        GameObject holder3 = Instantiate(temp, new Vector3(path[path.Count-1 ].transform.position.x -offset, 0, path[path.Count-1 ].transform.position.z), Quaternion.identity) as GameObject;
                        fix(holder3);
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
	    for(int i = 0; i < count; i++)
        {
            int rand = Random.Range(1, 5);
            float sc = Random.Range(1.0f, 2.0f);
            float col = Random.Range(0.0f, 1.0f);
            float col1 = Random.Range(0.0f, 1.0f);

            float col2 = Random.Range(0.0f, 1.0f);
            
            switch (rand)
            {
                case 1:
                    {
                        path[i].transform.Rotate(new Vector3(jiggle,0,0));
                        //path[i].transform.position += new Vector3(moveJiggle, 0, 0) * Time.deltaTime;
   //                path[i].transform.localScale = new Vector3(sc, sc, sc);
                        path[i].GetComponent<Renderer>().material.color = Color.HSVToRGB(col, col1, col2);
                        break;
                    }
                case 2:
                    {
                        path[i].transform.Rotate(new Vector3(-jiggle,0,0));
                   //     path[i].transform.position += new Vector3(-moveJiggle, 0, 0)*Time.deltaTime;

 //         path[i].transform.localScale = new Vector3(sc, sc, sc);
                        path[i].GetComponent<Renderer>().material.color = Color.HSVToRGB(col, col1, col2);

                        break;
                    }
                case 3:
                    {
                        path[i].transform.Rotate(new Vector3(0, -jiggle, 0));
                  //      path[i].transform.position += new Vector3(0, -moveJiggle, 0) * Time.deltaTime;

   //    path[i].transform.localScale = new Vector3(sc, sc, sc);
                        path[i].GetComponent<Renderer>().material.color =  Color.HSVToRGB(col, col1, col2);

                        break;
                    }
                case 4:
                    {
                        path[i].transform.Rotate(new Vector3(0, jiggle, 0));
                //        path[i].transform.position += new Vector3(0, moveJiggle, 0) * Time.deltaTime;

//      path[i].transform.localScale = new Vector3(sc, sc, sc);
                        path[i].GetComponent<Renderer>().material.color = Color.HSVToRGB(col, col1, col2);

                        break;
                    }
                default:
                    break;
            }
           


        }
    }
}
