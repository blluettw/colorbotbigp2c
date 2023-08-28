using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

public class ILabel : Label
{
    private Font CFont = new Font("Segoe UI", 10);
    public ILabel()
    {
        Font = CFont;
        ForeColor = Color.FromArgb(200, 200, 200);
    }
    private TextRenderingHint _textRenderingHint = TextRenderingHint.SystemDefault;
    public TextRenderingHint TextRenderingHint
    {
        get
        {
            return _textRenderingHint;
        }
        set
        {
            _textRenderingHint = value;
        }
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.TextRenderingHint = _textRenderingHint;
        base.OnPaint(e);
    }
}
