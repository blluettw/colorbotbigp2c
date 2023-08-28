using System;
using System.Drawing;
using System.Windows.Forms;

namespace Utorrent.FGBox
{
    public partial class FGBox : Form
    {
        // 0 = erro
        // 1 = aviso
        string contents;

        private void Findtype(int type, string contents)
        {
            switch (type)
            {
                case 0:
                    tipomsg.Text = "Erro";
                    content.Text = contents;
                    break;
                case 1:
                    tipomsg.Text = "Aviso";
                    content.Text = contents;
                    break;
            }

        }
        public FGBox(int type, string content)
        {
            InitializeComponent();
            Findtype(type, content);
            contents = content;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (content.Text.Length >= 30)
            {
                content.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            }
            if (content.Text.Length >= 70)
            {
                MessageBox.Show(contents, "FG RASPBERRY");
                Close();
            }
            content.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            content.Left = (this.ClientSize.Width - content.Width) / 2;
            content.Top = (this.ClientSize.Height - content.Height) / 2 - 10;
        }

        private void siticoneGradientCircleButton1_Click(object sender, EventArgs e)
        {
        }

        private void content_SizeChanged(object sender, EventArgs e)
        {
        }

        private void siticoneButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botao1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
