namespace win_forms_thing;

public partial class Form1 : Form
{
  public Form1()
  {
    InitializeComponent();

    var mult = 20;

    var textBox = new TextBox { Location = new Point { X = mult, Y = mult * 1 } };

    var button = new Button { Text = "Click me", Location = new Point { X = mult, Y = mult * 3 } };

    button.Click += (sender, e) =>
    {
      MessageBox.Show(textBox.Text);
    };

    Controls.Add(textBox);
    Controls.Add(button);
  }
}
