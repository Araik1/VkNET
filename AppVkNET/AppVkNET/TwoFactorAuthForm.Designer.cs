namespace AppVkNET
{
    partial class TwoFactorAuthForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_borderMove = new System.Windows.Forms.Panel();
            this.buttonCloseApp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAth = new System.Windows.Forms.Button();
            this.textBoxPas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_borderMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_borderMove
            // 
            this.panel_borderMove.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel_borderMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(118)))), ((int)(((byte)(164)))));
            this.panel_borderMove.Controls.Add(this.buttonCloseApp);
            this.panel_borderMove.Controls.Add(this.label1);
            this.panel_borderMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_borderMove.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel_borderMove.Location = new System.Drawing.Point(0, 0);
            this.panel_borderMove.Name = "panel_borderMove";
            this.panel_borderMove.Size = new System.Drawing.Size(402, 33);
            this.panel_borderMove.TabIndex = 1;
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
            this.buttonCloseApp.Location = new System.Drawing.Point(360, 0);
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
            this.label1.Location = new System.Drawing.Point(22, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Проверка безопасности";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMouseUp);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(23, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(379, 58);
            this.label5.TabIndex = 4;
            this.label5.Text = "Чтобы подтвердить, что Вы являетесь владельцем страницы, пожалуйста, введите код " +
    "из уведомления, отправленного в приложение AppVkNET.";
            // 
            // buttonAth
            // 
            this.buttonAth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(118)))), ((int)(((byte)(164)))));
            this.buttonAth.FlatAppearance.BorderSize = 0;
            this.buttonAth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAth.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAth.ForeColor = System.Drawing.Color.White;
            this.buttonAth.Location = new System.Drawing.Point(135, 210);
            this.buttonAth.Name = "buttonAth";
            this.buttonAth.Size = new System.Drawing.Size(147, 34);
            this.buttonAth.TabIndex = 3;
            this.buttonAth.Text = "Отправить";
            this.buttonAth.UseVisualStyleBackColor = false;
            this.buttonAth.Click += new System.EventHandler(this.buttonAth_Click);
            // 
            // textBoxPas
            // 
            this.textBoxPas.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPas.ForeColor = System.Drawing.Color.Black;
            this.textBoxPas.Location = new System.Drawing.Point(135, 152);
            this.textBoxPas.Name = "textBoxPas";
            this.textBoxPas.Size = new System.Drawing.Size(184, 23);
            this.textBoxPas.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(38, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите код";
            // 
            // TwoFactorAuthForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(402, 311);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAth);
            this.Controls.Add(this.textBoxPas);
            this.Controls.Add(this.panel_borderMove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TwoFactorAuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TwoFactorAuthForm";
            this.panel_borderMove.ResumeLayout(false);
            this.panel_borderMove.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_borderMove;
        private System.Windows.Forms.Button buttonCloseApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPas;
    }
}