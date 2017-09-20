using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using FlexBusiness.CodedUI.Test;

namespace AprobarOrdenCompra
{
    /// <summary>
    /// Descripción resumida de CodedUITest1
    /// </summary>
    [CodedUITest]
    public class AprobarOrdenCompra
    {
        public AprobarOrdenCompra()
        {
        }

        [TestMethod]
        public void CUITAprobarOrdenCompra()
        {
            // Para generar código para esta prueba, seleccione "Generar código para prueba de IU codificada" en el menú contextual y seleccione uno de los elementos de menú.
            uICodedUI.Menu2("FlexBusiness ERP 4.2 - 4110000", "explorerBar", "COMPRAS", "Operaciones", "Ordenes de compra", "Ordenes de compra - Pendientes");
            uICodedUI.Lista("FlexBusiness ERP 4.2 - 4110000", "frmVistaAdministrativaListView2", "UltraListView1", "005-0009015");
            uICodedUI.Comando("FlexBusiness ERP 4.2 - 4110000", "Aprobar comprobante");
            uICodedUI.ClicBoton("Ejecución en lote", "Aceptar");

        }

        #region Atributos de prueba adicionales

        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:

        ////Use TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // Para generar código para esta prueba, seleccione "Generar código para prueba de IU codificada" en el menú contextual y seleccione uno de los elementos de menú.
        //}

        ////Use TestCleanup para ejecutar el código después de ejecutar cada prueba
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // Para generar código para esta prueba, seleccione "Generar código para prueba de IU codificada" en el menú contextual y seleccione uno de los elementos de menú.
        //}

        #endregion

        /// <summary>
        ///Obtiene o establece el contexto de las pruebas que proporciona
        ///información y funcionalidad para la serie de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public CodedUI uICodedUI
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new CodedUI();
                }

                return this.map;
            }
        }

        private CodedUI map;

    }
}
