using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
  [SerializeField]
  private int groundWidth, groundHeight;

  [SerializeField]
  private Tile tile;

  [SerializeField]
  private Transform cam;


  void Start()
  {
    GenerateGrid();
  }

  void Update()
  {
        
  }

  void GenerateGrid()
  {
    for (int x = 0; x < groundWidth; x++)
    {
      for (int y = 0; y < groundHeight; y++)
      {
        var spawnedTile = Instantiate(tile, new Vector3(x, 0.05f, y), Quaternion.identity);
        spawnedTile.name = $"Tile {x}-{y}";
      }
    }

    cam.transform.position = new Vector3((float)groundWidth / 2 - 0.05f, (float)groundHeight / 3 - 0.05f);
  }
}
