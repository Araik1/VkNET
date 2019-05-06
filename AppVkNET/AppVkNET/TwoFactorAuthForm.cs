using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppVkNET
{
    public partial class TwoFactorAuthForm : Form
    {
        public TwoFactorAuthForm()
        {
            InitializeComponent();
            
        }
        public string codeAuth => textBoxPas.Text;

        private void buttonAth_Click(object sender, EventArgs e)
        {
            if (codeAuth == "")
            {
                textBoxPas.ForeColor = Color.Red;
                return;
            }
            this.Hide();
        }

        //===================Перемещение окна==============================
        private System.Drawing.Point mouseOffset;
        private bool isMouseDown = false;

        private void panelMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOffset = new System.Drawing.Point(-e.X, -e.Y);
                isMouseDown = true;
            }
        }
        private void panelMouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                System.Drawing.Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }
        private void panelMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
        private void closeApp(object sender, EventArgs e)
        {
            this.Close();
        }
        //=================================================================  
    }
}
