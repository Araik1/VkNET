using AppVkNET;
using System;
using System.Windows.Forms;
using VkNet.Enums.Filters;
using VkNet.Exception;
using VkNet.Model;

namespace VkNet
{
    public partial class Form_main : Form
    {

        private string userName;
        private string password;

        private VkApi api;
        private ulong IDApp;
        private ApiAuthParams auth;
        private Settings scope;



        public Form_main()
        {
            InitializeComponent();
            api = new VkApi();
            IDApp = 6975168;
            scope = Settings.All;
            auth = new ApiAuthParams();

        }

        private bool isLogedVk(string login, string password)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
                return false;

            try
            {
                auth.ApplicationId = IDApp;
                auth.Password = password;
                auth.Login = login;
                auth.Settings = scope;

                api.Authorize(auth);

            }
            catch (System.Exception)
            {
                auth.TwoFactorAuthorization = () =>
                {
                    using (TwoFactorAuthForm authForm = new TwoFactorAuthForm())
                    {
                        authForm.ShowDialog();
                        return authForm.codeAuth;
                    }
                };
                api.Authorize(auth);

            }
            /*catch (CaptchaNeededException exc)
            {
               Обработка капчи при авторизации 
            }*/

            return true;
        }

        private void buttonAth_Click(object sender, EventArgs e)
        {
            userName = textBoxUser.Text.ToString();
            password = textBoxPas.Text.ToString();

            if (isLogedVk(userName, password))
            {
                Console.WriteLine(api.Token);

            }

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
