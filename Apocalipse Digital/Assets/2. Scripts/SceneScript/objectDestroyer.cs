using UnityEngine;

public class objectDestroyer : MonoBehaviour
{
    public float secondsToDestroy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, secondsToDestroy);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
