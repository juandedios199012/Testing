using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;

namespace FlexBusiness.CodedUI.Test
{
    public class CodedUI
    {
        public void Menu1(string nombreApp, string nombreTipoMenu, string nombreMenu, string nombreSubMenu, string nombreArbol2)
        {
            WinWindow UIAppWindow = new WinWindow();
            WinWindow UITipoMenu = new WinWindow(UIAppWindow);
            WinButton UIMenu = new WinButton(UITipoMenu);
            WinTreeItem UISubMenu = new WinTreeItem(UIMenu);
            WinTreeItem UIArbol2 = new WinTreeItem(UISubMenu);


            UIAppWindow.SearchProperties[WinWindow.PropertyNames.Name] = nombreApp;
            UIAppWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            UIAppWindow.WindowTitles.Add(nombreApp);

            UITipoMenu.SearchProperties[WinWindow.PropertyNames.ControlName] = nombreTipoMenu;
            UITipoMenu.WindowTitles.Add(nombreApp);

            UIMenu.SearchProperties[WinButton.PropertyNames.Name] = nombreMenu;
            UIMenu.WindowTitles.Add(nombreApp);

            UISubMenu.SearchProperties[WinTreeItem.PropertyNames.Name] = nombreSubMenu;
            UISubMenu.SearchProperties["Value"] = "0";
            UISubMenu.WindowTitles.Add(nombreApp);

            Mouse.Click(UIMenu);
            UISubMenu.Expanded = true;

            UIArbol2.SearchProperties.Add("Name", nombreArbol2);
            Mouse.Click(UIArbol2);


        }
        public void Menu2(string nombreApp, string nombreTipoMenu, string nombreMenu, string nombreSubMenu, string nombreArbol2, string nombreArbol3)
        {
            WinWindow UIAppWindow = new WinWindow();
            WinWindow UITipoMenu = new WinWindow(UIAppWindow);
            WinButton UIMenu = new WinButton(UITipoMenu);
            WinTreeItem UISubMenu = new WinTreeItem(UIMenu);
            WinTreeItem UIArbol2 = new WinTreeItem(UISubMenu);
            WinTreeItem UIArbol3 = new WinTreeItem(UIArbol2);

            UIAppWindow.SearchProperties[WinWindow.PropertyNames.Name] = nombreApp;
            UIAppWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            UIAppWindow.WindowTitles.Add(nombreApp);

            UITipoMenu.SearchProperties[WinWindow.PropertyNames.ControlName] = nombreTipoMenu;
            UITipoMenu.WindowTitles.Add(nombreApp);

            UIMenu.SearchProperties[WinButton.PropertyNames.Name] = nombreMenu;
            UIMenu.WindowTitles.Add(nombreApp);

            UISubMenu.SearchProperties[WinTreeItem.PropertyNames.Name] = nombreSubMenu;
            UISubMenu.SearchProperties["Value"] = "0";
            UISubMenu.WindowTitles.Add(nombreApp);

            Mouse.Click(UIMenu);
            UISubMenu.Expanded = true;

            UIArbol2.SearchProperties.Add("Name", nombreArbol2);
            UIArbol2.Expanded = true;

            UIArbol3.SearchProperties.Add("Name", nombreArbol3);
            Mouse.Click(UIArbol3);
        }

        public void PropiedadesGrid3(string nombreApp, string cadena, string tecla)
        {
            WinWindow windows = new WinWindow();
            WinRow winrow = new WinRow(windows);
            WinEdit gridWinedit = new WinEdit(winrow);
            WinEdit winEdit = new WinEdit(windows);
            WinWindow UIItemWindow = new WinWindow(windows);

            windows.SearchProperties[WinWindow.PropertyNames.Name] = nombreApp;

            windows.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            windows.SearchProperties.Add("ControlName", "Grid");

            windows.WindowTitles.Add(nombreApp);
            //System.Diagnostics.Debug.WriteLine("hola pande: " + windows.ControlName);

            winrow.SearchProperties[UITestControl.PropertyNames.Name] = "row 1";
            winrow.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            winrow.WindowTitles.Add(nombreApp);
            System.Diagnostics.Debug.WriteLine("hola pande2: " + winrow.ControlName);

            System.Diagnostics.Debug.WriteLine("hola pande3: " + gridWinedit.ControlName);
            gridWinedit.WindowTitles.Add(nombreApp);
            System.Diagnostics.Debug.WriteLine("hola pande: " + windows.ControlName);

            UIItemWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.EDIT", PropertyExpressionOperator.Contains));
            UIItemWindow.WindowTitles.Add(nombreApp);
            System.Diagnostics.Debug.WriteLine("hola pande: " + UIItemWindow.ControlName);

            winEdit.SetProperty("ControlName", "");
            winEdit.WindowTitles.Add(nombreApp);
            System.Diagnostics.Debug.WriteLine("hola pande: " + winEdit.ControlName);

            Mouse.Click(gridWinedit);
            winEdit.Text = cadena;
            Keyboard.SendKeys(winEdit, tecla, ModifierKeys.None);
        }

        public void Comando(string nombreApp, string nombreComando)
        {
            WinWindow UIAppWindow = new WinWindow();
            WinButton uIcomando = new WinButton(UIAppWindow);

            UIAppWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            UIAppWindow.WindowTitles.Add(nombreApp);

            uIcomando.SearchProperties.Add("Name", nombreComando);
            Mouse.Click(uIcomando);
        }

        public void ClicBoton(string nombreApp, string nombreButton)
        {
            WinWindow UIAppWindow = new WinWindow();
            WinButton uIButton = new WinButton(UIAppWindow);

            UIAppWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            UIAppWindow.WindowTitles.Add(nombreApp);

            uIButton.SearchProperties.Add("Name", nombreButton);

            Mouse.Click(uIButton);
        }
        public void ClicMessageBox(string nombreApp, string nombreButton, string idControl = "")
        {
            WinWindow UIAppWindow = new WinWindow();
            WinWindow window = new WinWindow(UIAppWindow);
            WinButton uIButton = new WinButton(window);

            UIAppWindow.SearchProperties[WinWindow.PropertyNames.Name] = nombreApp;
            UIAppWindow.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32770";
            UIAppWindow.WindowTitles.Add(nombreApp);

            window.SearchProperties[WinWindow.PropertyNames.ControlId] = idControl;
            window.WindowTitles.Add(nombreApp);

            uIButton.SearchProperties.Add("Name", nombreButton);
            window.WindowTitles.Add(nombreApp);

            Mouse.Click(uIButton);
        }
        public void CheckBox(string nombreApp, string nombreControl)
        {
            WinWindow UIAppWindow = new WinWindow();
            WinCheckBox chkBox = new WinCheckBox(UIAppWindow);

            UIAppWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            UIAppWindow.WindowTitles.Add(nombreApp);

            chkBox.SearchProperties.Add("ControlName", nombreControl);
            Mouse.Click(chkBox);
        }
        public void EdtitarCadena(string nombreApp, string nombreControl, string valor)
        {
            WinWindow UIAppWindow = new WinWindow();
            WinWindow UIControl = new WinWindow(UIAppWindow);
            //WinEdit clicEdti = new WinEdit(UIControl);
            WinEdit edtit = new WinEdit(UIControl);

            WinWindow UIItemWindow = new WinWindow(UIAppWindow);
            WinEdit UIItemEdtit = new WinEdit(UIItemWindow);

            UIAppWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            UIAppWindow.WindowTitles.Add(nombreApp);

            //clicEdti.WindowTitles.Add(nombreApp);

            UIControl.SearchProperties[WinWindow.PropertyNames.ControlName] = nombreControl;
            UIControl.WindowTitles.Add(nombreApp);

            edtit.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.EDIT", PropertyExpressionOperator.Contains));
            edtit.WindowTitles.Add(nombreApp);

            edtit.WindowTitles.Add(nombreApp);

            edtit.SearchProperties.Add("ControlName", nombreControl);

            UIItemWindow.SearchProperties.Add("ClassName", "WindowsForms10.EDIT");
            UIItemEdtit.SearchProperties.Add("ClassName", "WindowsForms10.EDIT.app.0.378734a");
            Mouse.Click(edtit);
            UIItemEdtit.Text = valor;
            //Keyboard.SendKeys(UIItemEdtit, valor);
        }
        public void Lista(string nombreApp, string nombreControl, string valor, string nombreLista = "")
        {
            WinWindow UIAppWindow = new WinWindow();
            WinWindow vistaAdministrativa = new WinWindow(UIAppWindow);
            WinList vistaLista = new WinList(vistaAdministrativa);
            WinListItem itemLista = new WinListItem(vistaLista);

            UIAppWindow.SearchProperties[WinWindow.PropertyNames.Name] = nombreApp;
            UIAppWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            UIAppWindow.WindowTitles.Add(nombreApp);

            vistaAdministrativa.SearchProperties[WinWindow.PropertyNames.ControlName] = nombreControl;
            vistaAdministrativa.WindowTitles.Add(nombreApp);

            vistaLista.SearchProperties[WinList.PropertyNames.Name] = nombreLista;
            vistaLista.WindowTitles.Add(nombreApp);

            itemLista.SearchProperties[WinListItem.PropertyNames.Name] =  valor.Trim();
            itemLista.WindowTitles.Add(nombreApp);

            Mouse.Click(itemLista);

        }
        public void Tab(string nombreApp, string valor)
        {
            WinWindow UIAppWindow = new WinWindow();
            WinTabPage tabPage = new WinTabPage(UIAppWindow);

            UIAppWindow.SearchProperties[WinWindow.PropertyNames.Name] = nombreApp;
            UIAppWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            UIAppWindow.WindowTitles.Add(nombreApp);

            tabPage.SearchProperties[WinTabPage.PropertyNames.Name] = valor;
            tabPage.WindowTitles.Add(nombreApp);

            Mouse.Click(tabPage);
        }

        public void Asercion(string nombreApp, string nombrechkBox, bool valor)
        {
            WinWindow UIAppWindow = new WinWindow();
            WinCheckBox chkBox = new WinCheckBox(UIAppWindow);

            UIAppWindow.SearchProperties[WinWindow.PropertyNames.Name] = nombreApp;
            UIAppWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            UIAppWindow.WindowTitles.Add(nombreApp);

            chkBox.SearchProperties[WinCheckBox.PropertyNames.Name] = nombrechkBox;
            chkBox.WindowTitles.Add(nombreApp);

            Assert.AreEqual(valor, chkBox.Checked);
        }
        public void IngresarValor(string nombreApp,  string valor, string nombreControl = "")
        {
            WinWindow UIAppWindow = new WinWindow();
            WinEdit oEdit = new WinEdit(UIAppWindow);

            UIAppWindow.SearchProperties[WinWindow.PropertyNames.Name] = nombreApp;
            UIAppWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            UIAppWindow.WindowTitles.Add(nombreApp);

            oEdit.SearchProperties[WinEdit.PropertyNames.ControlName] = nombreControl;
            oEdit.WindowTitles.Add(nombreApp);

             Keyboard.SendKeys(oEdit, valor);
        }
        public void SeleccionRefencia(string nombreApp, string nombreControl, string instancia,string accionTecla)
        {
            WinWindow UIAppWindow = new WinWindow();
            WinWindow UIUBuscarWindow = new WinWindow(UIAppWindow);
            WinEdit oEdit = new WinEdit(UIUBuscarWindow);

            UIAppWindow.SearchProperties[WinWindow.PropertyNames.Name] = nombreApp;
            UIAppWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            UIAppWindow.WindowTitles.Add(nombreApp);

            UIUBuscarWindow.SearchProperties[WinEdit.PropertyNames.ControlName] = nombreControl;
            UIUBuscarWindow.SearchProperties[WinEdit.PropertyNames.Instance] = instancia;
            UIUBuscarWindow.WindowTitles.Add(nombreApp);

            oEdit.WindowTitles.Add(nombreApp);

            Mouse.Click(oEdit);
            Keyboard.SendKeys(oEdit, accionTecla, ModifierKeys.None);
        }
        public void Enter(string nombreControl, string valor)
        {
            WinWindow UIAppWindow = new WinWindow();
            WinEdit oEdit = new WinEdit(UIAppWindow);
   
            oEdit.SearchProperties[WinEdit.PropertyNames.ControlName] = nombreControl;

            if (valor== "{Enter}")
                Keyboard.SendKeys(oEdit, valor,ModifierKeys.None);
            else
                Keyboard.SendKeys(oEdit, valor);
        }
        public void IngresarValorCelda(string nombreApp,string nombreControl,string nombreCelda,string fila,string valor,string accionTecla)
        {
            WinWindow UIAppWindow = new WinWindow();
            WinWindow UIGridWindow = new WinWindow(UIAppWindow);
            WinTable UIGridTable = new WinTable(UIGridWindow);
            WinRow UIRow = new WinRow(UIGridTable);
            WinCell UICell = new WinCell(UIRow);
            WinWindow UIItemWindow = new WinWindow(UIAppWindow);
            WinEdit UIItemEdit = new WinEdit(UIItemWindow);
            
            UIAppWindow.SearchProperties[WinWindow.PropertyNames.Name] = nombreApp;
            UIAppWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            UIAppWindow.WindowTitles.Add(nombreApp);

            UIGridWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = nombreControl;
            UIGridWindow.WindowTitles.Add(nombreApp);

            UIGridTable.WindowTitles.Add(nombreApp);

            UIRow.SearchProperties[WinRow.PropertyNames.Name] = fila;
            UIRow.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            UIRow.WindowTitles.Add(nombreApp);
            
            UICell.SearchProperties[WinCell.PropertyNames.Name] = nombreCelda;
            UICell.WindowTitles.Add(nombreApp);
            Mouse.Click(UICell);

            UIItemWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.EDIT", PropertyExpressionOperator.Contains));
            UIItemWindow.WindowTitles.Add(nombreApp);

            UIItemEdit.WindowTitles.Add(nombreApp);
            //UIItemEdit.Text = valor;

            Keyboard.SendKeys(UIItemEdit, valor);
            Keyboard.SendKeys(UIItemEdit, accionTecla, ModifierKeys.None);
        }
        public void ActualizarValorCelda(string nombreApp, string valorPorDefecto, string valor, string fila , string nombreControl, string accionTecla)
        {
            WinWindow UIAppWindow = new WinWindow();
            WinWindow UIGridWindow = new WinWindow(UIAppWindow);
            WinTable UIGridTable = new WinTable(UIGridWindow);
            WinRow UIRow = new WinRow(UIGridTable);
            WinCell UICell = new WinCell(UIRow);
            WinEdit UIItemEdit = new WinEdit(UIRow);

            UIAppWindow.SearchProperties[WinWindow.PropertyNames.Name] = nombreApp;
            UIAppWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            UIAppWindow.WindowTitles.Add(nombreApp);

            UIGridWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = nombreControl;
            UIGridWindow.WindowTitles.Add(nombreApp);

            UIGridTable.WindowTitles.Add(nombreApp);

            UIRow.SearchProperties[WinRow.PropertyNames.Name] = fila;
            UIRow.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            UIRow.WindowTitles.Add(nombreApp);

            UICell.SearchProperties[WinCell.PropertyNames.Value] = valorPorDefecto;
            UICell.WindowTitles.Add(nombreApp);

            Mouse.Click(UICell);

            UIItemEdit.WindowTitles.Add(nombreApp);
            //UIItemEdit.Text = valor;
            Keyboard.SendKeys(UIItemEdit, valor);
            Keyboard.SendKeys(UIItemEdit, accionTecla, ModifierKeys.None);
        }
        public void AsercionGrabarDatos(string nombreApp, string nombreControl, string nombreLista, string nombreItemLista)
        {
            WinWindow UIAppWindow = new WinWindow();
            WinWindow UIVistaWindow = new WinWindow(UIAppWindow);
            WinList UILvItemsList = new WinList(UIVistaWindow);
            WinListItem UIItemListItem = new WinListItem(UILvItemsList);

            UIAppWindow.SearchProperties[WinWindow.PropertyNames.Name] = nombreApp;
            UIAppWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            UIAppWindow.WindowTitles.Add(nombreApp);

            UIVistaWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = nombreControl;
            UIVistaWindow.WindowTitles.Add(nombreApp);

            UILvItemsList.SearchProperties[WinList.PropertyNames.Name] = nombreLista;
            UILvItemsList.WindowTitles.Add(nombreApp);

            UIItemListItem.SearchProperties[WinListItem.PropertyNames.Name] = nombreItemLista;
            UIItemListItem.WindowTitles.Add(nombreApp);

            Assert.AreEqual(nombreItemLista, UIItemListItem.Name, "Pedido Pendiente Grabado");

        }
        public void AsercionConsultaDatoGrilla(string nombreApp, string nombreControl, string fila,string valor)
        {
            WinWindow UIAppWindow = new WinWindow();
            WinWindow UIGridWindow = new WinWindow(UIAppWindow);
            WinTable UIGridTable = new WinTable(UIGridWindow);
            WinRow UIRow = new WinRow(UIGridTable);
            WinCell UIItemCell= new WinCell(UIRow);

            UIAppWindow.SearchProperties[WinWindow.PropertyNames.Name] = nombreApp;
            UIAppWindow.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            UIAppWindow.WindowTitles.Add(nombreApp);

            UIGridWindow.SearchProperties[WinWindow.PropertyNames.ControlName] = nombreControl;
            UIGridWindow.WindowTitles.Add(nombreApp);

            UIGridTable.WindowTitles.Add(nombreApp);

            UIRow.SearchProperties[WinRow.PropertyNames.Name] = fila;
            UIRow. SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            UIRow.WindowTitles.Add(nombreApp);

            UIItemCell.SearchProperties[WinCell.PropertyNames.Value] = valor;
            UIItemCell.WindowTitles.Add(nombreApp);

            Assert.AreEqual(UIItemCell, UIItemCell.Name, "Precio Correcto");

        }

        public bool Textbox_EnterText(string oWinName, string oWinControlType, string oTxtboxName, string valor, string oTxtboxControlType = "",string tecla="")   // generic function for entering value in a textbox
        {

            Boolean bolTxtboxExists;

            WinWindow uiwin = new WinWindow();
            WinWindow uiwin2 = new WinWindow(uiwin);
            WinCustom UIItemCustom = new WinCustom(uiwin2);
            WinWindow UITxtCodigo_EmbeddableWindow = new WinWindow(uiwin);
            WinEdit uiTxtbox = new WinEdit(uiwin);

            uiwin.SearchProperties[WinWindow.PropertyNames.Name] = oWinName;
            //uiwin.SearchProperties[WinWindow.PropertyNames.Name] = "Zona - 4110000";
            uiwin.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            uiwin.WindowTitles.Add(oWinName);

            uiwin2.SearchProperties[WinWindow.PropertyNames.ControlName] = oWinControlType;//"txtCodigo";
            uiwin2.WindowTitles.Add(oWinName);

            UIItemCustom.WindowTitles.Add(oWinName);
            Mouse.Click(UIItemCustom);

            UITxtCodigo_EmbeddableWindow.SearchProperties[WinWindow.PropertyNames.ControlId] = oTxtboxName; //"txtCodigo_EmbeddableTextBox";
            UITxtCodigo_EmbeddableWindow.WindowTitles.Add(oWinName);

            //uiwin.SearchProperties[WinWindow.PropertyNames.Name] = oWinName;
            //uiwin.SearchProperties[WinWindow.PropertyNames.ControlType] = oWinControlType;

            if (uiwin.Exists)
            {
                
                uiTxtbox.WindowTitles.Add(oWinName);
                uiTxtbox.SearchProperties[WinWindow.PropertyNames.Name] = oTxtboxControlType;//"txtCodigo";
                //uiTxtbox.SearchProperties[WinButton.PropertyNames.Name] = oTxtboxName;
                //uiTxtbox.SearchProperties[WinButton.PropertyNames.ControlType] = oTxtboxControlType;

                bolTxtboxExists = uiTxtbox.Exists;

                if (bolTxtboxExists)
                {
                    
                    Keyboard.SendKeys(uiTxtbox, valor);
                    
                    if (tecla != "") { 
                        Keyboard.SendKeys(uiTxtbox, tecla, ModifierKeys.None);
                    }
                    return true;
                }
                else
                {
                    Assert.IsTrue(bolTxtboxExists, "Textbox - " + oTxtboxName + " not found on the " + oWinName + " - Window. Please verify object repository or the properties of the control in the application");
                    return false;

                }
            }
            else
            {
                Assert.IsTrue(uiwin.Exists, "Window - " + oWinName + " - not found on the application. Please verify object repository or the properties of the control in the application");
                return false;
            }

        }




    }
}
