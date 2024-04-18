namespace Formas_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void setFormasImagem(string caminhoDaImagem)
        {
            formasImagem.Image = Image.FromFile(caminhoDaImagem);
        }
    }
}
