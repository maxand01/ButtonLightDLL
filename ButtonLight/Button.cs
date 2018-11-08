using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ButtonLight;
using LightDLL;

namespace PackageButton 
{
    public class Button 
    {
        private IAllumable _IAllumable;

        public Button(IAllumable IAllumable)
        {
            _IAllumable = IAllumable; 
        }      

        public void Press()
        {
            if (_IAllumable.IsOn)
                _IAllumable.TurnOff();
            else
                _IAllumable.TurnOn();
        }        
    }
}
