using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyMovieService;

namespace HelloMovie
{
    public partial class Form1 : Form
    {

        Movie x = new Movie();
        MoviesDataSite xe = MoviesDataSite.Instance();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                x = xe.GetMovieData(txt_name.Text.Trim());
                lbl_msg.Text = "";
                lbl_title.Text = x.Title;
                lbl_year.Text = x.Year.ToString();
                lbl_rated.Text = x.Rated;
                lbl_realesed.Text = x.Released;
                lbl_runtime.Text = x.Runtime;
                lbl_genre.Text = x.Genre;
                lbl_director.Text = x.Director;
                lbl_writer.Text = x.Writer;
                lbl_actors.Text = x.Actors;
                lbl_plot.Text = x.Plot;
                lbl_language.Text = x.Language;
                lbl_country.Text = x.Country;
                lbl_awards.Text = x.Awards;
                lbl_metascore.Text = x.Metascore.ToString();
                lbl_rating.Text = x.ImdbRating.ToString();
                lbl_imdbvotes.Text = x.ImdbVotes;
                lbl_imdbid.Text = x.ImdbID;
                lbl_type.Text = x.Type;
                pb_poster.Load(x.Poster);
            }
            catch
            {
                lbl_msg.Text = "Movie not exsit ! please try again";
                txt_name.Focus();
            }
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
