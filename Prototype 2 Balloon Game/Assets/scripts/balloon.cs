using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloon : MonoBehaviour
{
    public int ScoreToGive = 100; //Score give for popped balloon.

    public int ClickToPop = 3; //How many clicks before balloon pops.

    public float ScaleToIncrease = 0.10f; //Scale increase each time the balloon is clicked
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        // Reduce clicks by one
        ClickToPop -= 1;
        //Increase
        transform.localScale += Vector3.one * ScaleToIncrease;

        if(ClickToPop == 0)
        {
            Destroy(gameObject);
        }
    }
}


