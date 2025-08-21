namespace teste_parametro
{
    public partial class Form1 : Form

    {
        int numero = 100;
        string nome = "Letícia";
      
        public Form1()
        {
            InitializeComponent();
        }
      
        private void bt_teste_Click(object sender, EventArgs e)
        {
            numero += 1; //aumentando de 1 em 1
            TrocarTexto(bt_teste,numero,nome);
        }
         public static void TrocarTexto(Button my_bt_teste, int novo_numero, string nome)

        {
             
             my_bt_teste.Text = "Sucesso!" + novo_numero.ToString() + nome;

        }

    }
}
