
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Logique;


namespace Logique{
public  class Source : Composant{

    public Source(){
        this.state = 1;//Une source est toujours placée correctement
    }
    public override bool evaluate(){
        return true;
    }

}
}