using System;

namespace SnusSpelet.Models
{
    public class Dosa: _Snus{
        public int Amount { get; set;}
        
    public void TakeSnus(){
        if (Amount>0){
            Amount--;
        }
    }

    }




}