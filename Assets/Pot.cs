using UnityEngine;

public class Pot : MonoBehaviour
{


   void OnMouseDown()
   {
      GameManager.clicks++;
      print("clicked");
   }
}