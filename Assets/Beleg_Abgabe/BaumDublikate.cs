using UnityEngine;

/**
* Klasse um die Bäume im Spielmodus zu dublizieren
**/
public class BaumDublikate : MonoBehaviour
{
    public GameObject baumPrefab; 
    public int anzahlBaeume = 20;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Erstellt 20 Bäume irgnednwoe zufällig
    void Start()
    {
        for (int i = 0; i < anzahlBaeume; i++)
        {
            //Positionierung
            float x = Random.Range(-50f, 50f);
            float z = Random.Range(-50f, 50f);
            Vector3 randomPosition = new Vector3(x, 0, z);

            // Siehe Vorlesung 01
            Instantiate(baumPrefab, randomPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // brauchen wir nicht
    }
}
