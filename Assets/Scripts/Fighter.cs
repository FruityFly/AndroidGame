using UnityEngine;
using UnityEngine.InputSystem;


/*
 * Kafka Suenishi
 * 11/19/26 (happy GTAVI day!)
 * manages fighter behavior in shop and battle
 */


public class Fighter : MonoBehaviour
{

    [SerializeField] private InputAction press, screenPos;

    private Collider2D collider;
    private Vector3 startDragPosition;

    private void Start()
    {
        
        collider = GetComponent<Collider2D>();
        
    }




    private void OnMouseDown()
    {
        startDragPosition = transform.position;
        //transform.position = GetMousePositionInWorldSpace();
    }

}
