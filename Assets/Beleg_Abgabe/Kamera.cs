using UnityEngine;
/**
* Klasse für die Verfolgng des spieler Objektes
**/
public class Kamera : MonoBehaviour
{
    public Transform spieler;
    public float smooth = 5.0f;

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, spieler.position,Time.deltaTime * smooth);
    }
}


/*  public Transform spieler;
  public Vector3 offset;
  public float geschwindkeit = 0.125f;

  // Start is called once before the first execution of Update after the MonoBehaviour is created
  void Start()
  {
      if (offset == Vector3.zero)
      {
          offset = new Vector3(0, 1.5f, -4);
      }
  }

  void LateUpdate()
  {
      if (spieler != null)
      {
          // Spielerrotation übernehmen
          Quaternion playerRotation = spieler.rotation;

          // Offset mit der Spielerrotation multiplizieren
          Vector3 rotatedOffset = playerRotation * offset;

          // Zielposition der Kamera berechnen
          Vector3 targetPosition = spieler.position + rotatedOffset;

          // Kamera glatt zur Zielposition bewegen
          transform.position = Vector3.Lerp(transform.position, targetPosition, geschwindkeit);

          // Optional: Die Kamera soll dem Spieler leicht folgen, ohne direkt seine Rotation zu übernehmen
          // Hier kannst du die Rotation anpassen, um sie weniger direkt zu machen
          Vector3 lookDirection = spieler.position - transform.position;
          Quaternion lookRotation = Quaternion.LookRotation(lookDirection);
          transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, geschwindkeit);


      /*   if (spieler != null)
         {
             // Berechne die neue Kameraposition
             Vector3 kameraPos = spieler.position + spieler.rotation * offset;
             Vector3 kameraUebergang = Vector3.Lerp(transform.position, kameraPos, geschwindkeit);
             transform.position = kameraUebergang;

             // Blickrichtung des Spielers zu folgen
             Quaternion zielRotation = spieler.rotation * Quaternion.Euler(10, 0, 0);
             transform.rotation = Quaternion.Slerp(transform.rotation, zielRotation, geschwindkeit);

             Debug.Log("Kamera Position:" + transform.position);
             Debug.Log("Spiler Position:" + spieler.position);
         }
         else
         {
             Debug.Log("KEINSPIELER)");
         }
  }*/