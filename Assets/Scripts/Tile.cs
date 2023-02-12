using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
  [SerializeField]
  private Color color;

  [SerializeField]
  private GameObject tile;

  [SerializeField]
  private Material materialColor;
  [SerializeField]
  private Material secondaryMaterial;

  private GameObject clickedTile;

  void Start()
  {
    materialColor.color = color;
  }

  // Update is called once per frame
  void Update()
  {
        
  }

  private void OnMouseDown()
  {
    clickedTile = GameObject.Find(tile.name);

    clickedTile.GetComponent<MeshRenderer>().material = secondaryMaterial;
  }
}
