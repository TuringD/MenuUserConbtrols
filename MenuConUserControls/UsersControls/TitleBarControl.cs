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
        public string AppName { internal get; set; } = "Your application name";
        /// <summary>
        /// Color del fondo del user control
        /// </summary>
        public Color Backcolor { internal get; set; } = Color.FromArgb(30, 30, 30);
        /// <summary>
        /// Color de la division entre el titlebar y el contenido del formuario formulario 
        /// </summary>
        public Color DivColor { internal get; set; } = Color.FromArgb(225, 27, 59);
        /// <summary>
        /// Establece una imagen a el user control 
        /// </summary>
        public Image AppLogo { internal get; set; } = Properties.Resources.QE_LOGO;
        /// <summary>
        /// Agregar la barra de titlulo al formulario
        /// </summary>
        public void AddTitleBar()
        {
            if(FrmMenu != null)
            {
                FrmMenu.FormBorderStyle = FormBorderStyle.None;
                UserControl TTb = InitTitleBar();
                FrmMenu.Controls.Add(TTb);
            }
        }
        /// <summary>
        /// Inicializar el contorl Titlebar  y sus caracteristicas
        /// </summary>
        /// <returns></returns>
        private UserControl InitTitleBar()
        {
            //----------------------------------------------
            // Title label 
            //----------------------------------------------
            Label lblTitle = new Label();
            lblTitle.Text = AppName;            
            lblTitle.Font = new Font("MS Reference Sans Serif" ,24,FontStyle.Bold);
            lblTitle.Location = new Point(78, 14);
            lblTitle.AutoSize = true;
            lblTitle.ForeColor = Color.White;
            //----------------------------------------------
            // AppImg  picturebox
            //----------------------------------------------
            PictureBox AppImg = new PictureBox();
            AppImg.SizeMode = PictureBoxSizeMode.Zoom;
            AppImg.Location = new Point(14, 9);
            AppImg.Size = new Size(58, 50);
            AppImg.Image = AppLogo;
            //----------------------------------------------
            // Div Panel
            //----------------------------------------------
            Panel dvpnl = new Panel();
            dvpnl.BackColor = DivColor;
            dvpnl.Size = new Size(745, 8);
            dvpnl.Dock = DockStyle.Bottom;
            //----------------------------------------------
            // Closebtn Button
            //----------------------------------------------
            Button btn = new Button();
            btn.Text = "X";
            btn.MaximumSize = new Size(37, 30);
            btn.Dock = DockStyle.Right;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseDownBackColor = Color.Red;
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn.ForeColor = Color.White;
            //----------------------------------------------
            //  Titlebar UserControl
            //----------------------------------------------
            UserControl TTB = new UserControl();
            TTB.Size = new Size(745, 72);
            TTB.Dock = DockStyle.Top;
            TTB.BackColor = Backcolor;


            TTB.Controls.Add(btn);
            TTB.Controls.Add(lblTitle);
            TTB.Controls.Add(AppImg);
            TTB.Controls.Add(dvpnl);
            return TTB;
        }
        //realizar las lineas que rodean al formulario
    }
}
