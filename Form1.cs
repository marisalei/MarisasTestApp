namespace MarisaTestApp
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.Linq;
	using System.Windows.Forms;

    public partial class Form1 : Form
    {
        BindingList<Person> _personen = new();
        List<string> _geschlechter = new List<string>
        {
            "weiblich",
            "männlich",
            "divers"
        };

        string _vorname;
        string _nachname;
        int _alter;
        string _geschlecht;


        public Form1()
        {
            InitializeComponent();
            AnzeigePersonenListBox.DisplayMember = nameof(Person.DisplayName);
            AnzeigePersonenListBox.DataSource = _personen;
            GeschlechtComboBox.DataSource = _geschlechter;
        }

        private void OnHinzufügenButton_Click(object sender, EventArgs e)
        {
            var vorname = VornameTextBox.Text;
            var nachname = NachnameTextBox.Text;
            var id = _personen.Any() ? _personen.Max(p => p.Id) + 1 : 0;
            var alter = (int)AlterNumericUpDown.Value;
            var geschlecht = (string)GeschlechtComboBox.SelectedItem;

            if (!vorname.Equals(String.Empty) && !nachname.Equals(String.Empty) && !geschlecht.Equals(String.Empty))
            {
                var person = new Person
                {
                    Id = id,
                    Nachname = nachname,
                    Vorname = vorname,
                    Alter = alter,
                    Geschlecht = geschlecht,
                };
                _personen.Add(person);
            }
            else
            {
                MessageBox.Show("Bitte Vor- und Nachnamen eingeben");
            }

            TextfelderLeeren();
        }

        private void OnÄndernButton_Click(object sender, EventArgs e)
        {
            if (AnzeigePersonenListBox.SelectedValue != null)
            {
                var selectedPerson = (Person)AnzeigePersonenListBox.SelectedItem;
                var id = int.Parse(IDLabel.Text);

                EingegebeneWerteInPersonÜbernehmen();


                var person = _personen.First(eachPerson => eachPerson.Id == id);
                if (!_vorname.Equals(String.Empty) && !_nachname.Equals(String.Empty))
                {
                    person.Vorname = _vorname;
                    person.Nachname = _nachname;
                    person.Alter = _alter;
                    person.Geschlecht = _geschlecht;

                }
                else
                {
                    MessageBox.Show("Bitte Vor- und Nachnamen eingeben");
                }

                //AnzeigePersonenListBox.DataSource = _personen;
                //AnzeigePersonenListBox.DisplayMember = nameof(Person.DisplayName);
                _personen.ResetBindings();

                //_geschlechter.ResetBindings();
                GeschlechtComboBox.DataSource = null;
                GeschlechtComboBox.DataSource = _geschlechter;
            }
            else
            {
                MessageBox.Show("Keine Person ausgewählt.");
            }
        }

        private void OnLöschenButton_Click(object sender, EventArgs e)
        {

            if (AnzeigePersonenListBox.SelectedValue != null)
            {
                var selectedPerson = (Person)AnzeigePersonenListBox.SelectedItem;
                var id = int.Parse(IDLabel.Text);

                var person = _personen.First(eachPerson => eachPerson.Id == id);

                _personen.Remove(person);
                TextfelderLeeren();

            }
            else
            {
                MessageBox.Show("Keine Person ausgewählt.");
            }
        }

        private void OnAnzeigePersonenListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (AnzeigePersonenListBox.SelectedValue != null)
            {

                var selectedPerson = (Person)AnzeigePersonenListBox.SelectedItem;

                VornameTextBox.Text = selectedPerson.Vorname;
                NachnameTextBox.Text = selectedPerson.Nachname;
                IDLabel.Text = selectedPerson.Id.ToString();
                AlterNumericUpDown.Value = selectedPerson.Alter;
                GeschlechtComboBox.Text = selectedPerson.Geschlecht;
            }

        }
        private void OnTextfelderLeerenButton_Click(object sender, EventArgs e)
        {
            TextfelderLeeren();
        }

        private void OnNachAlterSortierenAufwärtsButton_Click(object sender, EventArgs e)
        {
            var sortiertePersonen = _personen.OrderBy(p => p.Alter).ToList();
            _personen.Clear();
            foreach (var person in sortiertePersonen)
            {
                _personen.Add(person);
            }
        }

        private void OnNachAlterSortierenAbwärtsButton_Click(object sender, EventArgs e)
        {
            var sortiertePersonen = _personen.OrderByDescending(p => p.Alter).ToList();
            _personen.Clear();
            foreach (var person in sortiertePersonen)
            {
                _personen.Add(person);
            }
        }

        private void OnNachIDSortierenButton_Click(object sender, EventArgs e)
        {
            var sortiertePersonen = _personen.OrderBy(p => p.Id).ToList();
            _personen.Clear();
            foreach (var person in sortiertePersonen)
            {
                _personen.Add(person);
            }
        }

        private void OnNachGeschlechtUndAlterSortierenButton_Click(object sender, EventArgs e)
        {
            var sortiertePersonen = _personen.OrderBy(p => GetGeschlechtReihenfolge(p.Geschlecht)).ThenBy(p => p.Alter).ToList();
            _personen.Clear();
            foreach (var person in sortiertePersonen)
            {
                _personen.Add(person);
            }
        }

        private void TextfelderLeeren()
        {
            VornameTextBox.Text = String.Empty;
            NachnameTextBox.Text = String.Empty;
            IDLabel.Text = String.Empty;
            AlterNumericUpDown.Value = 25;
            GeschlechtComboBox.SelectedIndex = 0;
            AnzeigePersonenListBox.SelectedIndex = -1;
        }

        private void EingegebeneWerteInPersonÜbernehmen()
        {
            if (AnzeigePersonenListBox.SelectedValue != null)
            {
                _vorname = VornameTextBox.Text;
                _nachname = NachnameTextBox.Text;
                _alter = (int)AlterNumericUpDown.Value;
                _geschlecht = (string)GeschlechtComboBox.SelectedItem;
            }
            else
            {
                MessageBox.Show("Keine Person ausgewählt.");
            }
        }


        private int GetGeschlechtReihenfolge(String geschlecht) => _geschlechter.IndexOf(geschlecht);
    }
}
