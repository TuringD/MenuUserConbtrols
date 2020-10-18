using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuConUserControls.UsersControls
{
    public class TitleBarControl
    {
        /// <summary>
        /// Formulario donde se agregara el user control
        /// </summary>
        public Form FrmMenu { internal get; set; } = null;
        /// <summary>
        /// Nombre de la aplicacion
        /// </summary>
        public string ApplicationName { internal get; set; } = "Your application name";
        public Color Backcolor { internal get; set; }
        /// <summary>
        /// Agregar la barra de titlulo al formulario
        /// </summary>
        public void AddTitleBar()
        {

        }
        /// <summary>
        /// Inicializar el contorl Titlebar  y sus caracteristicas
        /// </summary>
        /// <returns></returns>
        //private UserControl InitTitleBar()
        //{
        //    Label lblTitle = new Label();
        //    UserControl TTB = new UserControl();
        //    TTB.BackColor = Backcolor;

        //}
        //realizar las lineas que rodean al formulario
    }
}
