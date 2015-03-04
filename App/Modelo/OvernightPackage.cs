using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class OvernightPackage:Package
    {
        #region "Atributos"

        private string costoentrega;
        private string preciofijo;
        #endregion


        #region "Propiedades"

        public string ValorEntrega
        {
            get { return preciofijo; }
            set { preciofijo = value; }
        }

        public string calculateCost
        {
            get { return valorenvio; }
            set { valorenvio = value; }
        }

        #endregion
    }
}