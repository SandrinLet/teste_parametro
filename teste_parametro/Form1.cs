namespace teste_parametro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_teste_Click(object sender, EventArgs e)
        {
            TrocarTexto(bt_teste);
        }
         public static void TrocarTexto(Button my_bt_teste)
        {
             my_bt_teste.Text = "Sucesso!";

        }

    }
}
