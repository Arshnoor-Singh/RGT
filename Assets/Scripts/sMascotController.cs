using UnityEngine;
using UnityEngine.Splines;

public class sMascotController : MonoBehaviour
{
    [SerializeField] private SplineAnimate mascotSplineAnimate;
    
    //Variable for Character Speed on Spline
    public float movementSpeed = 20;
    private void Awake()
    {
        //mascotSplineAnimate.MaxSpeed = 0;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Function will be called by the SceneController when the player will have to move
    public void MoveMascot()
    {
        mascotSplineAnimate.MaxSpeed = movementSpeed;
    }
}
