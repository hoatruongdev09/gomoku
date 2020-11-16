using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardTile : MonoBehaviour {
    public bool IsMarked { get => isMarked; set => isMarked = value; }

    [SerializeField] private bool isMarked;
    [SerializeField] private SpriteRenderer spriteRenderer;
}