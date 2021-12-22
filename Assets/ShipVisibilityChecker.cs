using UnityEngine;

public class ShipVisibilityChecker : MonoBehaviour
{
    [SerializeField]
    ScreenWrap _screenWrap;
    private void OnBecameInvisible()
    {
        //Raise event
        _screenWrap.ScreenWrapMethod(transform.position);
       
    }
}
