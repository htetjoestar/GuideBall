using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitBox : MonoBehaviour
{
    // Start is called before the first frame update
    public accell ball;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other){
        ball.transform.position = new Vector3(0f,4.5f,0f);
        ball.gamestart = false;
        ball.rb.constraints = RigidbodyConstraints2D.FreezeAll;
    }
}
