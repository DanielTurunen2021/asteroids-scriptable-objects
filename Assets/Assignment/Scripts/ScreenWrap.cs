using System;
using UnityEngine;

public class ScreenWrap : MonoBehaviour
{
   [SerializeField] Transform playerTransform;
   private Camera _camera;
   private Vector3 viewpos;
   
   public delegate void Del(Vector3 vector);
   public static event Del ScreenWrapEvent;


   private void OnEnable()
   {
      ScreenWrapEvent += ScreenWrapMethod;
   }

   private void OnDisable()
   {
      ScreenWrapEvent -= ScreenWrapMethod;
   }


   private void OnBecameInvisible()
   {
      ScreenWrapEvent.Invoke(playerTransform.position);
   }

   private void Awake()
   {
      _camera = Camera.main;
      viewpos = _camera.WorldToViewportPoint(playerTransform.position);
   }
   

   //Listen to event.
   public void ScreenWrapMethod(Vector3 position)
   {
      var newposition = position; 
      viewpos = _camera.WorldToViewportPoint(position);
      if (viewpos.x > 1 || viewpos.x < 0)
      {
         newposition.x = - newposition.x;
      }

      if (viewpos.y > 1 || viewpos.y < 0)
      {
         newposition.y = -newposition.y;
      }
      playerTransform.position = newposition;
   }
}
