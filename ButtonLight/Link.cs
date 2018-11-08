using LightDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonLight
{
    public class Link : IAllumable
    {
        private Light _light;

        public Link(Light light)
        {
            _light = light;
        }
        public bool IsOn
        {
            get { return _light.IsLightOn; }
        }

        public void TurnOff()
        {
            _light.LightOff();
        }

        public void TurnOn()
        {
            _light.LightOn();
        }

        public override string ToString()
        {
            if (IsOn)
                return "Allumé";
            else
                return "Eteint";
        }
    }
}
