using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuConUserControls.UsersControls
{
    public class UsersControls
    {
        #region  TitleBarUserControl
        public Form FrmMenu { internal get; set; } = null; // definicion del formulario
        public string AplicationName { get; set; } // definicion del nombre del formulario      

        /// <summary>
        /// funcion para agrgar la barra de titulo desde codigo
        /// </summary>
        public void AddTitleBar()
        {

        }

        //private UserControl InitTitleBar()
        //{
        //    UserControl TTB = new UserControl();
        //    TTB.bac

        //}
        /// <summary>
        /// Cerrar el formulario desde el UserControl  TitleBar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            if(FrmMenu != null)
            {
                FrmMenu.Close();
                //Application.ExitThread(); // Cerrar la aplicacion por completo
            }
        }
        #endregion
    }
}
