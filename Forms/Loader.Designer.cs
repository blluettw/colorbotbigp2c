namespace Utorrent.Forms
{
    partial class Loader
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
            this.components = new System.ComponentModel.Container();
            this.RBElipse = new Siticone.Desktop.UI.WinForms.SiticoneElipse(this.components);
            this.tabc1drag = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.login = new System.Windows.Forms.TabPage();
            this.botao1 = new Botao();
            this.iLabel3 = new ILabel();
            this.iLabel1 = new ILabel();
            this.Entrar = new Botao();
            this.senhaLG = new TxtBox();
            this.userLG = new TxtBox();
            this.tabs = new System.Windows.Forms.TabControl();
            this.reg = new System.Windows.Forms.TabPage();
            this.iLabel5 = new ILabel();
            this.iLabel4 = new ILabel();
            this.iLabel2 = new ILabel();
            this.keyRG = new TxtBox();
            this.Register = new Botao();
            this.senhaRG = new TxtBox();
            this.userRG = new TxtBox();
            this.tabc2drag = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.pldrag = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.login.SuspendLayout();
            this.tabs.SuspendLayout();
            this.reg.SuspendLayout();
            this.SuspendLayout();
            // 
            // RBElipse
            // 
            this.RBElipse.TargetControl = this;
            // 
            // tabc1drag
            // 
            this.tabc1drag.DockIndicatorTransparencyValue = 0.6D;
            this.tabc1drag.TargetControl = this.login;
            this.tabc1drag.UseTransparentDrag = true;
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.Control;
            this.login.Controls.Add(this.botao1);
            this.login.Controls.Add(this.iLabel3);
            this.login.Controls.Add(this.iLabel1);
            this.login.Controls.Add(this.Entrar);
            this.login.Controls.Add(this.senhaLG);
            this.login.Controls.Add(this.userLG);
            this.login.Location = new System.Drawing.Point(4, 22);
            this.login.Name = "login";
            this.login.Padding = new System.Windows.Forms.Padding(3);
            this.login.Size = new System.Drawing.Size(398, 381);
            this.login.TabIndex = 0;
            this.login.Text = "ssss";
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // botao1
            // 
            this.botao1.Animated = true;
            this.botao1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.botao1.BorderRadius = 7;
            this.botao1.BorderThickness = 1;
            this.botao1.CheckedState.BorderColor = System.Drawing.Color.White;
            this.botao1.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.botao1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.botao1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.botao1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.botao1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.botao1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.botao1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.botao1.ForeColor = System.Drawing.Color.White;
            this.botao1.HoverState.BorderColor = System.Drawing.Color.White;
            this.botao1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.botao1.HoverState.ForeColor = System.Drawing.Color.White;
            this.botao1.Location = new System.Drawing.Point(207, 252);
            this.botao1.Name = "botao1";
            this.botao1.Size = new System.Drawing.Size(139, 48);
            this.botao1.TabIndex = 9;
            this.botao1.Text = "Sign up";
            this.botao1.Click += new System.EventHandler(this.botao1_Click);
            // 
            // iLabel3
            // 
            this.iLabel3.AutoSize = true;
            this.iLabel3.BackColor = System.Drawing.SystemColors.Control;
            this.iLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iLabel3.ForeColor = System.Drawing.Color.Black;
            this.iLabel3.Location = new System.Drawing.Point(80, 191);
            this.iLabel3.Name = "iLabel3";
            this.iLabel3.Size = new System.Drawing.Size(67, 19);
            this.iLabel3.TabIndex = 8;
            this.iLabel3.Text = "Password";
            this.iLabel3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // iLabel1
            // 
            this.iLabel1.AutoSize = true;
            this.iLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.iLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iLabel1.ForeColor = System.Drawing.Color.Black;
            this.iLabel1.Location = new System.Drawing.Point(80, 119);
            this.iLabel1.Name = "iLabel1";
            this.iLabel1.Size = new System.Drawing.Size(71, 19);
            this.iLabel1.TabIndex = 7;
            this.iLabel1.Text = "Username";
            this.iLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // Entrar
            // 
            this.Entrar.Animated = true;
            this.Entrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Entrar.BorderRadius = 7;
            this.Entrar.BorderThickness = 1;
            this.Entrar.CheckedState.BorderColor = System.Drawing.Color.White;
            this.Entrar.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.Entrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Entrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Entrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Entrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Entrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Entrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Entrar.ForeColor = System.Drawing.Color.White;
            this.Entrar.HoverState.BorderColor = System.Drawing.Color.White;
            this.Entrar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Entrar.HoverState.ForeColor = System.Drawing.Color.White;
            this.Entrar.Location = new System.Drawing.Point(62, 252);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(139, 48);
            this.Entrar.TabIndex = 2;
            this.Entrar.Text = "Entrar";
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // senhaLG
            // 
            this.senhaLG.Animated = true;
            this.senhaLG.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.senhaLG.BorderRadius = 8;
            this.senhaLG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.senhaLG.DefaultText = "";
            this.senhaLG.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.senhaLG.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.senhaLG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.senhaLG.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.senhaLG.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.senhaLG.FocusedState.BorderColor = System.Drawing.Color.White;
            this.senhaLG.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.senhaLG.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.senhaLG.ForeColor = System.Drawing.Color.Gray;
            this.senhaLG.HoverState.BorderColor = System.Drawing.Color.White;
            this.senhaLG.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.senhaLG.Location = new System.Drawing.Point(73, 210);
            this.senhaLG.Name = "senhaLG";
            this.senhaLG.PasswordChar = '\0';
            this.senhaLG.PlaceholderText = "";
            this.senhaLG.SelectedText = "";
            this.senhaLG.Size = new System.Drawing.Size(261, 36);
            this.senhaLG.TabIndex = 2;
            this.senhaLG.TextChanged += new System.EventHandler(this.senhaLG_TextChanged);
            this.senhaLG.Enter += new System.EventHandler(this.senhaLG_Enter);
            this.senhaLG.Leave += new System.EventHandler(this.senhaLG_Leave);
            // 
            // userLG
            // 
            this.userLG.Animated = true;
            this.userLG.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.userLG.BorderRadius = 8;
            this.userLG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userLG.DefaultText = "";
            this.userLG.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userLG.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userLG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userLG.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userLG.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.userLG.FocusedState.BorderColor = System.Drawing.Color.White;
            this.userLG.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.userLG.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userLG.ForeColor = System.Drawing.Color.Gray;
            this.userLG.HoverState.BorderColor = System.Drawing.Color.White;
            this.userLG.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.userLG.Location = new System.Drawing.Point(73, 141);
            this.userLG.Name = "userLG";
            this.userLG.PasswordChar = '\0';
            this.userLG.PlaceholderText = "";
            this.userLG.SelectedText = "";
            this.userLG.Size = new System.Drawing.Size(261, 36);
            this.userLG.TabIndex = 1;
            this.userLG.TextChanged += new System.EventHandler(this.userLG_TextChanged);
            this.userLG.Enter += new System.EventHandler(this.userLG_Enter);
            this.userLG.Leave += new System.EventHandler(this.userLG_Leave);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.login);
            this.tabs.Controls.Add(this.reg);
            this.tabs.Location = new System.Drawing.Point(105, -22);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(406, 407);
            this.tabs.TabIndex = 0;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // reg
            // 
            this.reg.BackColor = System.Drawing.SystemColors.Control;
            this.reg.Controls.Add(this.iLabel5);
            this.reg.Controls.Add(this.iLabel4);
            this.reg.Controls.Add(this.iLabel2);
            this.reg.Controls.Add(this.keyRG);
            this.reg.Controls.Add(this.Register);
            this.reg.Controls.Add(this.senhaRG);
            this.reg.Controls.Add(this.userRG);
            this.reg.Location = new System.Drawing.Point(4, 22);
            this.reg.Name = "reg";
            this.reg.Padding = new System.Windows.Forms.Padding(3);
            this.reg.Size = new System.Drawing.Size(398, 381);
            this.reg.TabIndex = 1;
            this.reg.Text = "tabPage2";
            this.reg.Click += new System.EventHandler(this.reg_Click);
            // 
            // iLabel5
            // 
            this.iLabel5.AutoSize = true;
            this.iLabel5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iLabel5.ForeColor = System.Drawing.Color.Black;
            this.iLabel5.Location = new System.Drawing.Point(73, 207);
            this.iLabel5.Name = "iLabel5";
            this.iLabel5.Size = new System.Drawing.Size(30, 19);
            this.iLabel5.TabIndex = 14;
            this.iLabel5.Text = "key";
            this.iLabel5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // iLabel4
            // 
            this.iLabel4.AutoSize = true;
            this.iLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iLabel4.ForeColor = System.Drawing.Color.Black;
            this.iLabel4.Location = new System.Drawing.Point(69, 146);
            this.iLabel4.Name = "iLabel4";
            this.iLabel4.Size = new System.Drawing.Size(67, 19);
            this.iLabel4.TabIndex = 13;
            this.iLabel4.Text = "Password";
            this.iLabel4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // iLabel2
            // 
            this.iLabel2.AutoSize = true;
            this.iLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iLabel2.ForeColor = System.Drawing.Color.Black;
            this.iLabel2.Location = new System.Drawing.Point(69, 85);
            this.iLabel2.Name = "iLabel2";
            this.iLabel2.Size = new System.Drawing.Size(71, 19);
            this.iLabel2.TabIndex = 12;
            this.iLabel2.Text = "Username";
            this.iLabel2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // keyRG
            // 
            this.keyRG.Animated = true;
            this.keyRG.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.keyRG.BorderRadius = 8;
            this.keyRG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyRG.DefaultText = "";
            this.keyRG.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.keyRG.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.keyRG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.keyRG.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.keyRG.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.keyRG.FocusedState.BorderColor = System.Drawing.Color.White;
            this.keyRG.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.keyRG.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.keyRG.ForeColor = System.Drawing.Color.Gray;
            this.keyRG.HoverState.BorderColor = System.Drawing.Color.White;
            this.keyRG.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.keyRG.Location = new System.Drawing.Point(73, 229);
            this.keyRG.Name = "keyRG";
            this.keyRG.PasswordChar = '\0';
            this.keyRG.PlaceholderText = "";
            this.keyRG.SelectedText = "";
            this.keyRG.Size = new System.Drawing.Size(261, 36);
            this.keyRG.TabIndex = 11;
            this.keyRG.TextChanged += new System.EventHandler(this.keyRG_TextChanged);
            this.keyRG.Enter += new System.EventHandler(this.keyRG_Enter);
            this.keyRG.Leave += new System.EventHandler(this.keyRG_Leave);
            // 
            // Register
            // 
            this.Register.Animated = true;
            this.Register.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.Register.BorderRadius = 7;
            this.Register.BorderThickness = 1;
            this.Register.CheckedState.BorderColor = System.Drawing.Color.White;
            this.Register.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.Register.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Register.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Register.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Register.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Register.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Register.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Register.ForeColor = System.Drawing.Color.Gray;
            this.Register.HoverState.BorderColor = System.Drawing.Color.White;
            this.Register.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Register.HoverState.ForeColor = System.Drawing.Color.White;
            this.Register.Location = new System.Drawing.Point(110, 271);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(185, 48);
            this.Register.TabIndex = 8;
            this.Register.Text = "Sign up";
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // senhaRG
            // 
            this.senhaRG.Animated = true;
            this.senhaRG.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.senhaRG.BorderRadius = 8;
            this.senhaRG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.senhaRG.DefaultText = "";
            this.senhaRG.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.senhaRG.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.senhaRG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.senhaRG.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.senhaRG.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.senhaRG.FocusedState.BorderColor = System.Drawing.Color.White;
            this.senhaRG.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.senhaRG.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.senhaRG.ForeColor = System.Drawing.Color.Gray;
            this.senhaRG.HoverState.BorderColor = System.Drawing.Color.White;
            this.senhaRG.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.senhaRG.Location = new System.Drawing.Point(73, 168);
            this.senhaRG.Name = "senhaRG";
            this.senhaRG.PasswordChar = '\0';
            this.senhaRG.PlaceholderText = "";
            this.senhaRG.SelectedText = "";
            this.senhaRG.Size = new System.Drawing.Size(261, 36);
            this.senhaRG.TabIndex = 9;
            this.senhaRG.TextChanged += new System.EventHandler(this.senhaRG_TextChanged);
            this.senhaRG.Enter += new System.EventHandler(this.senhaRG_Enter);
            this.senhaRG.Leave += new System.EventHandler(this.senhaRG_Leave);
            // 
            // userRG
            // 
            this.userRG.Animated = true;
            this.userRG.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.userRG.BorderRadius = 8;
            this.userRG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userRG.DefaultText = "";
            this.userRG.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userRG.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userRG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userRG.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userRG.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.userRG.FocusedState.BorderColor = System.Drawing.Color.White;
            this.userRG.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.userRG.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userRG.ForeColor = System.Drawing.Color.Gray;
            this.userRG.HoverState.BorderColor = System.Drawing.Color.White;
            this.userRG.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.userRG.Location = new System.Drawing.Point(73, 107);
            this.userRG.Name = "userRG";
            this.userRG.PasswordChar = '\0';
            this.userRG.PlaceholderText = "";
            this.userRG.SelectedText = "";
            this.userRG.Size = new System.Drawing.Size(261, 36);
            this.userRG.TabIndex = 7;
            this.userRG.TextChanged += new System.EventHandler(this.userRG_TextChanged);
            this.userRG.Enter += new System.EventHandler(this.userRG_Enter);
            this.userRG.Leave += new System.EventHandler(this.userRG_Leave);
            // 
            // tabc2drag
            // 
            this.tabc2drag.DockIndicatorTransparencyValue = 0.6D;
            this.tabc2drag.TargetControl = this.reg;
            this.tabc2drag.UseTransparentDrag = true;
            // 
            // pldrag
            // 
            this.pldrag.DockIndicatorTransparencyValue = 0.6D;
            this.pldrag.UseTransparentDrag = true;
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 379);
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Loader_FormClosing);
            this.Load += new System.EventHandler(this.Loader_Load);
            this.login.ResumeLayout(false);
            this.login.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.reg.ResumeLayout(false);
            this.reg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneElipse RBElipse;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage login;
        private System.Windows.Forms.TabPage reg;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl tabc1drag;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl tabc2drag;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl pldrag;
        private Botao Entrar;
        public TxtBox senhaLG;
        public TxtBox userLG;
        public TxtBox keyRG;
        private Botao Register;
        public TxtBox senhaRG;
        public TxtBox userRG;
        private ILabel iLabel3;
        private ILabel iLabel1;
        private Botao botao1;
        private ILabel iLabel5;
        private ILabel iLabel4;
        private ILabel iLabel2;
    }
}