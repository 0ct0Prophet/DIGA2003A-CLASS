using UnityEngine;

public class player : MonoBehaviour
{
    
   public float speed;
   

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("pressed the space key");
        }
    }
}
