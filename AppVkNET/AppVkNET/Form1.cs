using AppVkNET;
using System;
using System.Windows.Forms;
using VkNet.Enums.Filters;
using VkNet.Model;

namespace VkNet
{
    public partial class Form_main : Form
    {

        private string userName;
        private string password;

        private VkApi api;
        private ulong IDApp;

        public Form_main()
        {
            InitializeComponent();
            api = new VkApi();
            IDApp = 6972061;
        }

        private bool isLogedVk(string login, string password)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
                return false;

            try
            {
                try
                {
                    api.Authorize(new ApiAuthParams
                    {
                        ApplicationId = IDApp,
                        Login = login,
                        Password = password,
                        Settings = Settings.Messages,
                        TwoFactorAuthorization = () =>
                        {
                            using (TwoFactorAuthForm authForm = new TwoFactorAuthForm())
                            {
                                authForm.ShowDialog();
                                return authForm.codeAuth;
                            }
                        }
                    });
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                    return false;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
                return false;
            }

            return true;
        }
        private void buttonAth_Click(object sender, EventArgs e)
        {
            userName = textBoxUser.Text.ToString();
            password = textBoxPas.Text.ToString();

            if (isLogedVk(userName, password))
            {
                api.Messages.Send(new Model.RequestParams.MessagesSendParams
                {
                    RandomId = 12365,
                    ChatId = 153211133,
                    Message = "message"
                });
            }

            /*Console.WriteLine(api.Token);

            // Отправка сообщения себе
            api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams
            {
                ChatId = api.UserId.Value,
                Message = "message"
            });*/

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
