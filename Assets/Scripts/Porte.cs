
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




namespace Logique{
public abstract class Porte : Composant{
    public Composant[] previous = new Composant[2]; // Pour le prototype, on ne considère que les portes à deux entrées max
    public bool output=false;


    public void changeState(){ // On change l'état

        if(this.previous[0] is null){
            this.state = -1; // aucune porte n'a pas d'input
        }
        switch(this.output){
            case true:
                this.state = 1;
                break;
            case false:
                this.state = 0;
                break;
        }
        //Ici on change les matériaux
    }


    public void addPrevious(Composant composant){
        if(composant is null || this.previous[1] != null){
            return;//On ne peut pas ajouter : on n'ajoute pas
        }

        if(this.previous[0] != null){
            this.previous[1] = composant;
        }else{
            this.previous[0] = composant;
        }
    }


        public void removePrevious(Composant composant){
        if(composant.Equals(this.previous[0])){
            this.previous[0]= null;

        }else{
            this.previous[1]= null;
        }


    }

}
}