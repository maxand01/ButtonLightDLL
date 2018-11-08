using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonLight
{
    public class Convector : IAllumable
    {
        private bool _IsOn;

        public bool IsOn
        {
            get { return _IsOn; }
        }

        public Convector()
        {
            //L'état initial de la lampe est éteint
            _IsOn = false;
        }
        public void TurnOn()
        {
            _IsOn = true;
        }

        public void TurnOff()
        {
            _IsOn = false;
        }
        
    }
}
