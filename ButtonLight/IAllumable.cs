using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButtonLight
{
    public interface IAllumable
    {
        #region "Propriétés et accesseurs"
        #endregion
        #region "Constructeurs"
        #endregion
        #region "Methodes"
        void TurnOn();
        void TurnOff();
        bool IsOn { get;}
        #endregion
        #region "Methodes héritées et substituées"
        #endregion
        #region "Methodes à implementer pour les interfaces"
        #endregion

    }
}
