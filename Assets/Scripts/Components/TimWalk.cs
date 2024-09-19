using UnityEngine;
using Model;
using UnityEngine.SceneManagement;

public class TimWalk : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform start;
    public Transform finish;
    
    public float baseSpeed = 0.1f;

    private float elapsedTime = 0.0f;

    void Start()
    {
        if (StaticValues.PredictedWeather == StaticValues.ActualWeather)
        {
            baseSpeed = 0.2f;
        }
        baseSpeed = baseSpeed * StaticValues.PointsAwarded/90;
    }

 
    // Update is called once per frame
    void Update()
    {  
        if (transform.position != finish.position)	
        {
            elapsedTime += Time.deltaTime * baseSpeed;
            transform.position = Vector3.Lerp(start.position, finish.position, elapsedTime);
        }
        else
        {
            SceneManager.LoadScene("UIScene");
        }
    }
}
