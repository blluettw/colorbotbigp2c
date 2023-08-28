using Siticone.Desktop.UI.WinForms;

public class TxtBox : SiticoneTextBox
{
    public TxtBox()
    {
        Animated = true;
        BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
        BorderRadius = 8;
        Cursor = System.Windows.Forms.Cursors.IBeam;
        DefaultText = "";
        DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
        DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
        DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
        DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
        FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
        FocusedState.BorderColor = System.Drawing.Color.White;
        FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
        Font = new System.Drawing.Font("Segoe UI", 9F);
        HoverState.BorderColor = System.Drawing.Color.White;
        Location = new System.Drawing.Point(73, 144);
        PasswordChar = '\0';
        PlaceholderText = "";
        SelectedText = "";
        Size = new System.Drawing.Size(261, 36);
        TabIndex = 1;
    }
}
