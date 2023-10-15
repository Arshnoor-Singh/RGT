using UnityEngine;
using UnityEngine.Splines;

public class sSceneController : MonoBehaviour
{
    [Header("Operational References")]
    [SerializeField] private SplineContainer path;
    [SerializeField] private sMascotController mascotReference;

    //Following array hold the reference of each level prefab
    [Header("Level Location Prefab Array")]
    public sLevelLocation[] levelLocationArray;
    
    //Holds the value of the level the player is currently at for other scripts to reference
    private int currentLevel;
    
    // Start is called before the first frame update
    void Start()
    {
        //Set the current level to 1 by default
        currentLevel = 1;

        //Set Level Names
        SetLeveNames();
    }

    // Update is called once per frame
    // Figure out Sprite Index
    void Update()
    {

    }

    void VideoComplete()
    {
        mascotReference.ChangeMascotSpline();
        mascotReference.MoveMascot();
    }

    public int GetCurrentLevel()
    {
        return currentLevel;
    }


    public void NewLevelReached()
    {

    }

    //This function automatically sets the numbers on the flags when a scene is loaded
    void SetLeveNames()
    {
        for(int i = 0; i<=levelLocationArray.Length - 1; i++)
        {
            levelLocationArray[i].SetLevelCount(i+1);
        }
    }
}
