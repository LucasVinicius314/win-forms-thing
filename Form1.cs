namespace win_forms_thing;

public partial class Form1 : Form
{
  public Form1()
  {
    InitializeComponent();

    MessageBox.Show("aaaa");

    var button = new Button { Text = "aaaaa" };

    Controls.Add(button);
  }
}
