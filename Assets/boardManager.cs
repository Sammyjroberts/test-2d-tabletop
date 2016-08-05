using UnityEngine;
using System.Collections.Generic;

public class boardManager : MonoBehaviour
{
    public GameObject one;
    public GameObject two;
    public GameObject three;
    private int rows = 10;
    private int columns = 10;
    private List<Vector3> gridPositions = new List<Vector3>();
    // Use this for initialization
    void Start()
    {
        for (int x = 1; x < columns - 1; x++)
        {
            //Within each column, loop through y axis (rows).
            for (int y = 1; y < rows - 1; y++)
            {
                //At each index add a new Vector3 to our list with the x and y coordinates of that position.
                gridPositions.Add(new Vector3(x, y, 0f));
            }
        }
        for (int x = -1; x < columns + 1; x++)
        {
            //Loop along y axis, starting from -1 to place floor or outerwall tiles.
            for (int y = -1; y < rows + 1; y++)
            {
                GameObject toInstantiate = one;
                Instantiate(toInstantiate, new Vector3(x, y, 0f), Quaternion.identity);
            }
        }

    }
    void Update()
    {
    }
}