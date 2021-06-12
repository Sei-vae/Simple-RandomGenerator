using System;
using System.Windows.Forms;

namespace LottoGen
{
    public partial class LottoGen : Form
    {
        Random generator = new Random();
        int _zufallszahl;
        int _doppler;
        int[] _ziehung = new int[6];
        int[] _haeufigkeit = new int[49];

        public LottoGen()
        {
            InitializeComponent();
        }

        private void btnZiehen_Click(object sender, EventArgs e)
        {
            lblZiehungWerte.Text = string.Empty;
            _doppler = 0;

            for (int z = 0; z < 6; z++)
            {
                bool wiederhole = true;
                int i = 0;

                _zufallszahl = generator.Next(1, 50);
                do
                {
                    if (_ziehung[i] == _zufallszahl)
                    {
                        _zufallszahl = generator.Next(1, 50);
                        _doppler++;
                        i = 0;
                    }
                    else
                    {
                        if (i == z)
                        {
                            wiederhole = false;
                        }
                        else
                        {
                            i = i + 1;
                        }
                    }
                } while (wiederhole == true);

                _ziehung[z] = _zufallszahl;

                lblZiehungWerte.Text = lblZiehungWerte.Text +
                    _ziehung[z] + " - ";

                _haeufigkeit[_zufallszahl-1] = _haeufigkeit[_zufallszahl-1] + 1;
            }

            lblZiehungWerte.Text = 
                lblZiehungWerte.Text.TrimEnd(new char[] {' ', '-'});

            txtHaufig.Clear();

            for (int h = 0; h < 49; h++)
            {   //String.Format("Name = {0}, hours = {1:hh}", myName, DateTime.Now);
                txtHaufig.Text = txtHaufig.Text + String.Format("{0,2:d}", (h + 1)) +
                    "er --> " + _haeufigkeit[h] + Environment.NewLine;
            }

            lblDopp.Text = "Doppler: " + _doppler;
        }
    }
}
