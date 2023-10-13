using UnityEngine;
using UnityEngine.Splines;

public class sSceneController : MonoBehaviour
{
    [SerializeField] private SplineContainer path;
    [SerializeField] private sMascotController mascotReference;
    
    
    //Holds the value of the level the player is currently at
    private int currentStage;
    
    // Start is called before the first frame update
    void Start()
    {
        currentStage = 1;
    }

    // Update is called once per frame
    // Figure out Sprite Index
    void Update()
    {
        Debug.Log(path.EvaluatePosition(0, 0.9f));
    }

    void VideoComplete()
    {
        mascotReference.MoveMascot();
    }
}
