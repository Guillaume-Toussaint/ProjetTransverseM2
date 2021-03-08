
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Logique;


namespace Logique{
public  class PorteNot : Porte{
    public override bool evaluate(){
        this.output = !(this.previous[0].evaluate());//On inverse la valeur du précédent

        this.changeState();

        return this.output;
    }

    

}
}