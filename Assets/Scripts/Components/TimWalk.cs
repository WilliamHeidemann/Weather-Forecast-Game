using UnityEngine;

public class TimWalk : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform start;
    public Transform finish;
    
    public float speed = 1.0f;

    private float elapsedTime = 0.0f;

 
    // Update is called once per frame
    void Update()
    {  
        if (transform.position != finish.position)	
        {
            elapsedTime += Time.deltaTime * speed;
            transform.position = Vector3.Lerp(start.position, finish.position, elapsedTime);
        }
    }
}
