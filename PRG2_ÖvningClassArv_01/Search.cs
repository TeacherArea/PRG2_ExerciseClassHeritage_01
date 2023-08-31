namespace PRG2_ExerciseClassHeritage_01_solution
{
    public partial class Search : Form
    {
        // TODO ändra så att tabben följer rätt knapp/textbox
        // TODO gör en meny för att skapa nya listor, stänga programmet, etc ...
        List<Media> mediaList = new List<Media>();
        public Search()
        {
            InitializeComponent();
        }

        private void button_Registerbook_Click(object sender, EventArgs e)
        {
            Book book = new Book();

            // TODO glöm inte att säkra användarinput
            book.title = textBox_BookTitle.Text;
            book.pages = int.Parse(textBox_BookPages.Text);
            mediaList.Add(book);
            // TODO glöm inte tömma textboxen

            listBox_Showlibrary.Items.Add(book);
        }

        private void button_RegisterSound_Click(object sender, EventArgs e)
        {
            Sound sound = new Sound();

            // TODO glöm inte att säkra användarinput
            sound.title = textBox_SoundTitle.Text;
            sound.playTime = double.Parse(textBox_SoundPlayTime.Text);
            mediaList.Add((sound));
            // TODO glöm inte tömma textboxen

            listBox_Showlibrary.Items.Add((sound));
        }

        private void button_RegisterFilm_Click(object sender, EventArgs e)
        {
            Movies movie = new Movies();

            // TODO glöm inte att säkra användarinput
            movie.title = textBox_MovieTitle.Text;
            movie.playTime = double.Parse((textBox_MoviePlayTime.Text));
            mediaList.Add((movie));
            // TODO glöm inte tömma textboxen

            listBox_Showlibrary.Items.Add((movie));
        }
    }
}