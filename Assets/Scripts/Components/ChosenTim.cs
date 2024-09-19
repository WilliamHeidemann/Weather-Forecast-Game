using UnityEngine;

public class ChosenTim : MonoBehaviour
{

    public GameObject timSunglasses;
    public GameObject timUmbrella;
    public GameObject timSkies;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timSunglasses.SetActive(false);
        timUmbrella.SetActive(false);
        timSkies.SetActive(false);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
