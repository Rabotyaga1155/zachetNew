using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace zachet
{
    public partial class Form1 : Form
    {
        private List<Country> countries;
        private List<Hotel> hotels;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadHotels("oteli.txt");
            LoadCountry("countries.txt");
            PrintResult();
            


            




            void LoadCountry(string path)
            {
                countries = new List<Country>();
                try
                {
                    using (StreamReader reader = new StreamReader(path))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] parts = line.Split(',');
                            int id = int.Parse(parts[0]);
                            string name = parts[1];
                            countries.Add(new Country(id, name));
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка при загрузке файла");
                }
            }
            void LoadHotels(string path1)
            {
                hotels = new List<Hotel>();
                try
                {
                    using (StreamReader reader = new StreamReader(path1))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] parts = line.Split(',');
                            int typeId = int.Parse(parts[0]);
                            int id = int.Parse(parts[1]);
                            string name = parts[2];
                            int price = int.Parse(parts[3]);
                            hotels.Add(new Hotel(typeId, id, name, price));
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка при загрузке файла");
                }
            }






        }


        void PrintResult()
        {
            var query = from hotel in hotels
                        join country in countries on hotel.TypeId equals country.Id
                        select new
                        {
                            hotel.Id,
                            hotel.Name,
                            country.Na,
                            hotel.Price

                        };
            // string a = textBox3.Text.ToString();
            //switch(a)
            //{
            //    case "Идентификатор":
            //        query = query.OrderBy(result => result.Id);
            //        break;
            //}

            //var dic = query.GroupBy(h => h.Id).Select(g => g.First());
            foreach (var result in query)
            {

                dataGridView1.Rows.Add(result.Id,
                                       result.Name,
                                       result.Na,
                                       1,
                                       result.Price);
            }
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(2, 1000);
            try
            {
                
                //int typeId = int.Parse(textBox4.Text);
                //int id = int.Parse(textBox4.Text);
                //string name = textBox5.Text;
                //int price = int.Parse(textBox6.Text);

                dataGridView1.Rows.Add(a,textBox5.Text,textBox6.Text,numericUpDown2.Value,numericUpDown3.Value);

                //int countryId = int.Parse(textBox7.Text);
                //hotels.Add(new Hotel(typeId, id, name, price));

                //dataGridView1.Rows.Clear();
                // PrintResult();
            }
            catch
            {
                MessageBox.Show("Неверный ввод");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
