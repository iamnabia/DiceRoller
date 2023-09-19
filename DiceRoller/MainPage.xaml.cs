namespace DiceRoller;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        selecionarNumeroLados.SelectedIndex = 0;
    }

    public class Dice
    {

        private int numSides; //atributo

        public Dice() { }
        public Dice(int numSides) //parametro de entrada
        {
            this.numSides = numSides; //definindo variavel = parametro de entrada
        }

        public int RollDice()
        {
            int random = new Random().Next(1, numSides + 1);
            return random;
        }


    }

    public void OnRollClicked(object sender, EventArgs e)
    {
        Dice dice = new Dice((int)selecionarNumeroLados.SelectedItem);
        numeroTela.Text = dice.RollDice().ToString();
    }
}


/*
public MainPage()
{
    InitializeComponent();
}

public void OnClicked(object sender, EventArgs e)
{
    int min = 1;
    var numLista = picker.SelectedItem;

    int max = int.Parse(numLista.ToString());

    Random rnd= new Random();

    int numeroGerado = rnd.Next(min, max);
    numeroTela.Text = numeroGerado.ToString();

}
*/