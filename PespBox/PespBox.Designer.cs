namespace Utorrent.FGBox
{
    partial class FGBox
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mover = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.tipomsg = new ILabel();
            this.bordaredonda = new Siticone.Desktop.UI.WinForms.SiticoneElipse(this.components);
            this.content = new ILabel();
            this.botao1 = new Botao();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mover
            // 
            this.mover.DockIndicatorTransparencyValue = 1D;
            this.mover.TargetControl = this.siticonePanel1;
            this.mover.UseTransparentDrag = true;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.siticonePanel1.Controls.Add(this.siticoneButton1);
            this.siticonePanel1.Controls.Add(this.tipomsg);
            this.siticonePanel1.Location = new System.Drawing.Point(-2, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(501, 44);
            this.siticonePanel1.TabIndex = 1;
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.Animated = true;
            this.siticoneButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.siticoneButton1.BorderColor = System.Drawing.Color.Empty;
            this.siticoneButton1.BorderRadius = 7;
            this.siticoneButton1.BorderThickness = 1;
            this.siticoneButton1.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.siticoneButton1.CheckedState.CustomBorderColor = System.Drawing.Color.Black;
            this.siticoneButton1.CheckedState.FillColor = System.Drawing.Color.Black;
            this.siticoneButton1.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoverState.BorderColor = System.Drawing.Color.Black;
            this.siticoneButton1.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.siticoneButton1.HoverState.FillColor = System.Drawing.Color.Black;
            this.siticoneButton1.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.siticoneButton1.Location = new System.Drawing.Point(407, 10);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.siticoneButton1.Size = new System.Drawing.Size(30, 21);
            this.siticoneButton1.TabIndex = 5;
            this.siticoneButton1.Text = "X";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click_1);
            // 
            // tipomsg
            // 
            this.tipomsg.AutoSize = true;
            this.tipomsg.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipomsg.ForeColor = System.Drawing.Color.White;
            this.tipomsg.Location = new System.Drawing.Point(15, 11);
            this.tipomsg.Name = "tipomsg";
            this.tipomsg.Size = new System.Drawing.Size(30, 21);
            this.tipomsg.TabIndex = 3;
            this.tipomsg.Text = "sts";
            this.tipomsg.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // bordaredonda
            // 
            this.bordaredonda.TargetControl = this;
            // 
            // content
            // 
            this.content.AutoSize = true;
            this.content.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.content.ForeColor = System.Drawing.Color.White;
            this.content.Location = new System.Drawing.Point(21, 58);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(81, 25);
            this.content.TabIndex = 4;
            this.content.Text = "content";
            this.content.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.content.SizeChanged += new System.EventHandler(this.content_SizeChanged);
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
            this.botao1.Location = new System.Drawing.Point(136, 200);
            this.botao1.Name = "botao1";
            this.botao1.Size = new System.Drawing.Size(158, 33);
            this.botao1.TabIndex = 2;
            this.botao1.Text = "OK";
            this.botao1.Click += new System.EventHandler(this.botao1_Click);
            // 
            // FGBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(435, 259);
            this.Controls.Add(this.botao1);
            this.Controls.Add(this.content);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FGBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl mover;
        private Siticone.Desktop.UI.WinForms.SiticoneElipse bordaredonda;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private ILabel content;
        private ILabel tipomsg;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Botao botao1;
    }
}

