using Siticone.Desktop.UI.WinForms;

public class Botao : SiticoneButton
{

    public Botao()
    {

        this.Animated = true;
        this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
        this.BorderRadius = 7;
        this.BorderThickness = 1;
        this.CheckedState.BorderColor = System.Drawing.Color.White;
        this.CheckedState.ForeColor = System.Drawing.Color.Black;
        this.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
        this.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
        this.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
        this.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
        this.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
        this.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.ForeColor = System.Drawing.Color.White;
        this.HoverState.BorderColor = System.Drawing.Color.White;
        this.Location = new System.Drawing.Point(154, 200);
        this.Size = new System.Drawing.Size(180, 45);
        this.TabIndex = 2;
    }
}

