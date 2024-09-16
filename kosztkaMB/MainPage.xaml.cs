namespace kosztkaMB
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
           Random r = new Random();
            int diceRoll = 6;
            if (K6.IsChecked)
            {
                 diceRoll = r.Next(1, 7);
            }
          

            CounterBtn.Text = "Wynik rzutu " + diceRoll.ToString();
        }
    }

}
