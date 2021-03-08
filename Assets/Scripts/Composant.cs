using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Logique{

public abstract class Composant : MonoBehaviour
{
    
    public int state = -1;// -1 : défaut/problème | 0 : faux | 1 : vrai   --- On garde l'incorrect ? 
    //état utilisé pour définir le matériel de l'objet


    void Start()
    {    }
    void Update()
    {
        
    }

    // Update is called once per frame
            /*
        Idée pour la détection : on part du modèle 3d dans un sens. De ce modèle, on fait un raycast

        Si le raycast rencontre un objet, on ajoute le composant en tant que composant previous de l'objet touché (on les connecte)
        Comme ça, au final, on a juste besoin de faire un evaluate sur le dernier objet pour que ça se fassse en cascade.
        
        Un retour ?
        */

//fonction qui permettra d'évaluer la valeur de vérité du composant
    public abstract bool evaluate();

}

}
