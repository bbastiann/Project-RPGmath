using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 4f;
    public Vector3 [] Entries;
    public static Vector3 LastPos;
    public static bool Combat;
    public static int nextEntry = 0;

    // Start is called before the first frame update
    void Start()
    {
        if(Combat){
            transform.position = LastPos;
            Combat = false;
        }
        else{
            transform.position = Entries[nextEntry];
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mov = new Vector3(
            Input.GetAxisRaw("Horizontal"),
            Input.GetAxisRaw("Vertical"),
            0
        );

        transform.position = Vector3.MoveTowards(
            transform.position,
            transform.position + mov,
            speed * Time.deltaTime
            );

    }
    
}
