using UnityEngine;

public class UseInterface : MonoBehaviour,IClass
{
    public void EndGame(int amount)
    {
        throw new System.NotImplementedException();
    }

    public int StartGame()
    {
        return 0;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
