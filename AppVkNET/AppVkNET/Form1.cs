using System;
using System.Windows.Forms;

using VkNet;
using VkNet.Enums.Filters;
using VkNet.Model;


namespace VkNet
{
    public partial class Form_main : Form
    {

        private string userName;
        private string password;

        VkApi api = new VkApi();

        public Form_main()
        {
            InitializeComponent();

        }

        private void buttonAth_Click(object sender, EventArgs e)
        {
            userName = textBoxUser.Text.ToString();
            password = textBoxPas.Text.ToString();

            api.Authorize(new ApiAuthParams
            {
                ApplicationId = 6972061,
                Login = userName,
                Password = password,
                Settings = Settings.All,
                TwoFactorAuthorization = () =>
                {
                    Console.WriteLine("Enter Code:");
                    return Console.ReadLine();
                }
            });

            Console.WriteLine(api.Token);

            // Отправка сообщения себе
            api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams
            {
                ChatId = api.UserId.Value,
                Message = "message"
            });
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
            System.Windows.Forms.Application.Exit();
        }
        //=================================================================  
    }
}
