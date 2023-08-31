namespace PRG2_ExerciseClassHeritage_01_solution
{
    partial class Search
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox_Book = new GroupBox();
            textBox_BookPages = new TextBox();
            textBox_BookTitle = new TextBox();
            label_bookpages = new Label();
            label_booktitle = new Label();
            button_Registerbook = new Button();
            groupBox_Sound = new GroupBox();
            textBox_SoundPlayTime = new TextBox();
            textBox_SoundTitle = new TextBox();
            label_Soundtime = new Label();
            label_Soundtitle = new Label();
            button_RegisterSound = new Button();
            groupBox_Movie = new GroupBox();
            label_Resolution = new Label();
            textBox_MovieResolution = new TextBox();
            textBox_MoviePlayTime = new TextBox();
            textBox_MovieTitle = new TextBox();
            label_Movietime = new Label();
            label_Movietitle = new Label();
            button_RegisterFilm = new Button();
            listBox_Showlibrary = new ListBox();
            groupBox_Book.SuspendLayout();
            groupBox_Sound.SuspendLayout();
            groupBox_Movie.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox_Book
            // 
            groupBox_Book.BackColor = Color.WhiteSmoke;
            groupBox_Book.Controls.Add(textBox_BookPages);
            groupBox_Book.Controls.Add(textBox_BookTitle);
            groupBox_Book.Controls.Add(label_bookpages);
            groupBox_Book.Controls.Add(label_booktitle);
            groupBox_Book.Controls.Add(button_Registerbook);
            groupBox_Book.Location = new Point(12, 12);
            groupBox_Book.Name = "groupBox_Book";
            groupBox_Book.Size = new Size(238, 128);
            groupBox_Book.TabIndex = 1;
            groupBox_Book.TabStop = false;
            groupBox_Book.Text = "Bok";
            // 
            // textBox_BookPages
            // 
            textBox_BookPages.Location = new Point(87, 48);
            textBox_BookPages.Name = "textBox_BookPages";
            textBox_BookPages.Size = new Size(137, 23);
            textBox_BookPages.TabIndex = 9;
            // 
            // textBox_BookTitle
            // 
            textBox_BookTitle.Location = new Point(87, 16);
            textBox_BookTitle.Name = "textBox_BookTitle";
            textBox_BookTitle.Size = new Size(137, 23);
            textBox_BookTitle.TabIndex = 8;
            // 
            // label_bookpages
            // 
            label_bookpages.AutoSize = true;
            label_bookpages.Location = new Point(15, 52);
            label_bookpages.Name = "label_bookpages";
            label_bookpages.Size = new Size(34, 15);
            label_bookpages.TabIndex = 7;
            label_bookpages.Text = "Sidor";
            // 
            // label_booktitle
            // 
            label_booktitle.AutoSize = true;
            label_booktitle.Location = new Point(15, 20);
            label_booktitle.Name = "label_booktitle";
            label_booktitle.Size = new Size(29, 15);
            label_booktitle.TabIndex = 6;
            label_booktitle.Text = "Titel";
            // 
            // button_Registerbook
            // 
            button_Registerbook.Location = new Point(149, 89);
            button_Registerbook.Name = "button_Registerbook";
            button_Registerbook.Size = new Size(75, 23);
            button_Registerbook.TabIndex = 5;
            button_Registerbook.Text = "Registrera";
            button_Registerbook.UseVisualStyleBackColor = true;
            button_Registerbook.Click += button_Registerbook_Click;
            // 
            // groupBox_Sound
            // 
            groupBox_Sound.BackColor = Color.WhiteSmoke;
            groupBox_Sound.Controls.Add(textBox_SoundPlayTime);
            groupBox_Sound.Controls.Add(textBox_SoundTitle);
            groupBox_Sound.Controls.Add(label_Soundtime);
            groupBox_Sound.Controls.Add(label_Soundtitle);
            groupBox_Sound.Controls.Add(button_RegisterSound);
            groupBox_Sound.Location = new Point(12, 149);
            groupBox_Sound.Name = "groupBox_Sound";
            groupBox_Sound.Size = new Size(238, 128);
            groupBox_Sound.TabIndex = 10;
            groupBox_Sound.TabStop = false;
            groupBox_Sound.Text = "Ljud";
            // 
            // textBox_SoundPlayTime
            // 
            textBox_SoundPlayTime.Location = new Point(87, 46);
            textBox_SoundPlayTime.Name = "textBox_SoundPlayTime";
            textBox_SoundPlayTime.Size = new Size(137, 23);
            textBox_SoundPlayTime.TabIndex = 9;
            // 
            // textBox_SoundTitle
            // 
            textBox_SoundTitle.Location = new Point(87, 15);
            textBox_SoundTitle.Name = "textBox_SoundTitle";
            textBox_SoundTitle.Size = new Size(137, 23);
            textBox_SoundTitle.TabIndex = 8;
            // 
            // label_Soundtime
            // 
            label_Soundtime.AutoSize = true;
            label_Soundtime.Location = new Point(15, 50);
            label_Soundtime.Name = "label_Soundtime";
            label_Soundtime.Size = new Size(43, 15);
            label_Soundtime.TabIndex = 7;
            label_Soundtime.Text = "Speltid";
            // 
            // label_Soundtitle
            // 
            label_Soundtitle.AutoSize = true;
            label_Soundtitle.Location = new Point(15, 19);
            label_Soundtitle.Name = "label_Soundtitle";
            label_Soundtitle.Size = new Size(29, 15);
            label_Soundtitle.TabIndex = 6;
            label_Soundtitle.Text = "Titel";
            // 
            // button_RegisterSound
            // 
            button_RegisterSound.Location = new Point(149, 89);
            button_RegisterSound.Name = "button_RegisterSound";
            button_RegisterSound.Size = new Size(75, 23);
            button_RegisterSound.TabIndex = 5;
            button_RegisterSound.Text = "Registrera";
            button_RegisterSound.UseVisualStyleBackColor = true;
            button_RegisterSound.Click += button_RegisterSound_Click;
            // 
            // groupBox_Movie
            // 
            groupBox_Movie.BackColor = Color.White;
            groupBox_Movie.Controls.Add(label_Resolution);
            groupBox_Movie.Controls.Add(textBox_MovieResolution);
            groupBox_Movie.Controls.Add(textBox_MoviePlayTime);
            groupBox_Movie.Controls.Add(textBox_MovieTitle);
            groupBox_Movie.Controls.Add(label_Movietime);
            groupBox_Movie.Controls.Add(label_Movietitle);
            groupBox_Movie.Controls.Add(button_RegisterFilm);
            groupBox_Movie.Location = new Point(12, 288);
            groupBox_Movie.Name = "groupBox_Movie";
            groupBox_Movie.Size = new Size(238, 148);
            groupBox_Movie.TabIndex = 10;
            groupBox_Movie.TabStop = false;
            groupBox_Movie.Text = "Film";
            // 
            // label_Resolution
            // 
            label_Resolution.AutoSize = true;
            label_Resolution.Location = new Point(15, 78);
            label_Resolution.Name = "label_Resolution";
            label_Resolution.Size = new Size(68, 15);
            label_Resolution.TabIndex = 11;
            label_Resolution.Text = "Upplösning";
            // 
            // textBox_MovieResolution
            // 
            textBox_MovieResolution.Location = new Point(87, 74);
            textBox_MovieResolution.Name = "textBox_MovieResolution";
            textBox_MovieResolution.Size = new Size(137, 23);
            textBox_MovieResolution.TabIndex = 10;
            // 
            // textBox_MoviePlayTime
            // 
            textBox_MoviePlayTime.Location = new Point(87, 44);
            textBox_MoviePlayTime.Name = "textBox_MoviePlayTime";
            textBox_MoviePlayTime.Size = new Size(137, 23);
            textBox_MoviePlayTime.TabIndex = 9;
            // 
            // textBox_MovieTitle
            // 
            textBox_MovieTitle.Location = new Point(87, 13);
            textBox_MovieTitle.Name = "textBox_MovieTitle";
            textBox_MovieTitle.Size = new Size(137, 23);
            textBox_MovieTitle.TabIndex = 8;
            // 
            // label_Movietime
            // 
            label_Movietime.AutoSize = true;
            label_Movietime.Location = new Point(15, 48);
            label_Movietime.Name = "label_Movietime";
            label_Movietime.Size = new Size(43, 15);
            label_Movietime.TabIndex = 7;
            label_Movietime.Text = "Speltid";
            // 
            // label_Movietitle
            // 
            label_Movietitle.AutoSize = true;
            label_Movietitle.Location = new Point(15, 17);
            label_Movietitle.Name = "label_Movietitle";
            label_Movietitle.Size = new Size(29, 15);
            label_Movietitle.TabIndex = 6;
            label_Movietitle.Text = "Titel";
            // 
            // button_RegisterFilm
            // 
            button_RegisterFilm.Location = new Point(149, 116);
            button_RegisterFilm.Name = "button_RegisterFilm";
            button_RegisterFilm.Size = new Size(75, 23);
            button_RegisterFilm.TabIndex = 5;
            button_RegisterFilm.Text = "Registrera";
            button_RegisterFilm.UseVisualStyleBackColor = true;
            button_RegisterFilm.Click += button_RegisterFilm_Click;
            // 
            // listBox_Showlibrary
            // 
            listBox_Showlibrary.FormattingEnabled = true;
            listBox_Showlibrary.ItemHeight = 15;
            listBox_Showlibrary.Location = new Point(279, 12);
            listBox_Showlibrary.Name = "listBox_Showlibrary";
            listBox_Showlibrary.Size = new Size(509, 424);
            listBox_Showlibrary.TabIndex = 11;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox_Showlibrary);
            Controls.Add(groupBox_Movie);
            Controls.Add(groupBox_Sound);
            Controls.Add(groupBox_Book);
            Name = "Search";
            Text = "Sök i biblioteket";
            groupBox_Book.ResumeLayout(false);
            groupBox_Book.PerformLayout();
            groupBox_Sound.ResumeLayout(false);
            groupBox_Sound.PerformLayout();
            groupBox_Movie.ResumeLayout(false);
            groupBox_Movie.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox_Book;
        private TextBox textBox_BookPages;
        private TextBox textBox_BookTitle;
        private Label label_bookpages;
        private Label label_booktitle;
        private Button button_Registerbook;
        private GroupBox groupBox_Sound;
        private TextBox textBox_SoundPlayTime;
        private TextBox textBox_SoundTitle;
        private Label label_Soundtime;
        private Label label_Soundtitle;
        private Button button_RegisterSound;
        private GroupBox groupBox_Movie;
        private TextBox textBox_MoviePlayTime;
        private TextBox textBox_MovieTitle;
        private Label label_Movietime;
        private Label label_Movietitle;
        private Button button_RegisterFilm;
        private ListBox listBox_Showlibrary;
        private Label label_Resolution;
        private TextBox textBox_MovieResolution;
    }
}