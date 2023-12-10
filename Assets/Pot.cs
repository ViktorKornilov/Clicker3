using UnityEngine;

public class Pot : MonoBehaviour
{
   public float shrinkSpeed = 5;
   public Vector3 rotateSpeed;
   AudioSource source;

   void Start()
   {
      source = GetComponent<AudioSource>();
   }

   void Update()
   {
      transform.Rotate(rotateSpeed * Time.deltaTime);

      if (transform.localScale.x > 1f)
      {
         transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;
      }
   }

   void OnMouseDown()
   {
      GameManager.clicks++;
      transform.localScale = Vector3.one * 1.3f;
      source.PlayOneShot(source.clip);
   }
}