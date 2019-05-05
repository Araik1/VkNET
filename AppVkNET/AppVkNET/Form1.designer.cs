namespace VkNet
{
    partial class Form_main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_borderMove = new System.Windows.Forms.Panel();
            this.buttonCloseApp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelAth = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAth = new System.Windows.Forms.Button();
            this.textBoxPas = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.panel_borderMove.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelAth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_borderMove
            // 
            this.panel_borderMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(118)))), ((int)(((byte)(164)))));
            this.panel_borderMove.Controls.Add(this.buttonCloseApp);
            this.panel_borderMove.Controls.Add(this.label1);
            this.panel_borderMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_borderMove.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel_borderMove.Location = new System.Drawing.Point(0, 0);
            this.panel_borderMove.Name = "panel_borderMove";
            this.panel_borderMove.Size = new System.Drawing.Size(692, 33);
            this.panel_borderMove.TabIndex = 0;
            this.panel_borderMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMouseDown);
            this.panel_borderMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMouseMove);
            this.panel_borderMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMouseUp);
            // 
            // buttonCloseApp
            // 
            this.buttonCloseApp.BackColor = System.Drawing.Color.DarkRed;
            this.buttonCloseApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCloseApp.FlatAppearance.BorderSize = 0;
            this.buttonCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseApp.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseApp.ForeColor = System.Drawing.Color.White;
            this.buttonCloseApp.Location = new System.Drawing.Point(650, 0);
            this.buttonCloseApp.Name = "buttonCloseApp";
            this.buttonCloseApp.Size = new System.Drawing.Size(42, 33);
            this.buttonCloseApp.TabIndex = 1;
            this.buttonCloseApp.Text = "X";
            this.buttonCloseApp.UseVisualStyleBackColor = false;
            this.buttonCloseApp.Click += new System.EventHandler(this.closeApp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "AppVkNET";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMouseUp);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.panelAth);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 33);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(692, 403);
            this.panelContent.TabIndex = 1;
            // 
            // panelAth
            // 
            this.panelAth.Controls.Add(this.pictureBox1);
            this.panelAth.Controls.Add(this.label2);
            this.panelAth.Controls.Add(this.label3);
            this.panelAth.Controls.Add(this.panelWelcome);
            this.panelAth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAth.Location = new System.Drawing.Point(0, 0);
            this.panelAth.Name = "panelAth";
            this.panelAth.Size = new System.Drawing.Size(692, 403);
            this.panelAth.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppVkNET.Properties.Resources._45868_2;
            this.pictureBox1.Location = new System.Drawing.Point(23, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(405, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(13, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = " Создано в академических целях и несет образовательный характер.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(37, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 52);
            this.label3.TabIndex = 1;
            this.label3.Text = "AppVKNET - прложение для демонсрации некоторых функций VK API.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelWelcome
            // 
            this.panelWelcome.Controls.Add(this.label5);
            this.panelWelcome.Controls.Add(this.label4);
            this.panelWelcome.Controls.Add(this.buttonAth);
            this.panelWelcome.Controls.Add(this.textBoxPas);
            this.panelWelcome.Controls.Add(this.textBoxUser);
            this.panelWelcome.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelWelcome.Location = new System.Drawing.Point(434, 0);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(258, 403);
            this.panelWelcome.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(14, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Пароль";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(14, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Телефон или email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAth
            // 
            this.buttonAth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(118)))), ((int)(((byte)(164)))));
            this.buttonAth.FlatAppearance.BorderSize = 0;
            this.buttonAth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAth.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAth.ForeColor = System.Drawing.Color.White;
            this.buttonAth.Location = new System.Drawing.Point(17, 165);
            this.buttonAth.Name = "buttonAth";
            this.buttonAth.Size = new System.Drawing.Size(147, 34);
            this.buttonAth.TabIndex = 1;
            this.buttonAth.Text = "Вход";
            this.buttonAth.UseVisualStyleBackColor = false;
            this.buttonAth.Click += new System.EventHandler(this.buttonAth_Click);
            // 
            // textBoxPas
            // 
            this.textBoxPas.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPas.Location = new System.Drawing.Point(17, 120);
            this.textBoxPas.Name = "textBoxPas";
            this.textBoxPas.PasswordChar = '*';
            this.textBoxPas.Size = new System.Drawing.Size(199, 23);
            this.textBoxPas.TabIndex = 0;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUser.Location = new System.Drawing.Point(17, 56);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(199, 23);
            this.textBoxUser.TabIndex = 0;
            // 
            // Form_main
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(692, 436);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panel_borderMove);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VkAPI";
            this.panel_borderMove.ResumeLayout(false);
            this.panel_borderMove.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelAth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_borderMove;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAth;
        private System.Windows.Forms.TextBox textBoxPas;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCloseApp;
    }
}

