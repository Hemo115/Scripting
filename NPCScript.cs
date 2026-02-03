using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour
{
    //Velocidad del NPC
    float NPCSpeed = 1.25f;
        //Vida del NPC
        int NPCHealth = 10;
        //nivel del NPC
        int NPCLevel = 3;
    // Start is called before the first frame update
    void Start()
    {
        NPCHealth += NPCLevel;
            print("vidas del NPC:" + NPCHealth);
    }

    // Update is called once per frame
    void Update()
    {
        // Tiene.que.guardar.la.posicion.del.NPC
        Vector3 newPosition = transform.position;
        // Cambia.z.segun.la.velocidad
        newPosition.z += NPCSpeed * Time.deltaTime;
        // Actualiza.la.posicion
        transform.position = newPosition;
        
    }
}
