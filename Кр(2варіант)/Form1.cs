using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Кр_2варіант_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {
            dgvRoutes.ColumnCount = 5;
            dgvRoutes.Columns[0].Name = "Route Number";
            dgvRoutes.Columns[1].Name = "Destination";
            dgvRoutes.Columns[2].Name = "Stops";
            dgvRoutes.Columns[3].Name = "Departure Time";
            dgvRoutes.Columns[4].Name = "Seats Available";

            dgvRoutes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoutes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoutes.MultiSelect = false;
            dgvRoutes.AllowUserToAddRows = false;

        }
        // Список рейсів
        private List<BusRoute> routes = new List<BusRoute>();

        // Обробник кнопки "Додати рейс"
        private void btnAddRoute_Click(object sender, EventArgs e)
        {
            AddRouteForm addForm = new AddRouteForm(); // Нова форма для додавання
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                routes.Add(addForm.NewRoute);
                UpdateDataGridView();
            }
        }

        // Обробник кнопки "Редагувати рейс"
        private void btnEditRoute_Click(object sender, EventArgs e)
        {
            if (dgvRoutes.SelectedRows.Count > 0)
            {
                int index = dgvRoutes.SelectedRows[0].Index;
                BusRoute selectedRoute = routes[index];

                AddRouteForm editForm = new AddRouteForm(selectedRoute);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    routes[index] = editForm.NewRoute;
                    UpdateDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть рейс для редагування!");
            }
        }

        // Обробник кнопки "Видалити рейс"
        private void btnDeleteRoute_Click(object sender, EventArgs e)
        {
            if (dgvRoutes.SelectedRows.Count > 0)
            {
                int index = dgvRoutes.SelectedRows[0].Index;
                routes.RemoveAt(index);
                UpdateDataGridView();
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть рейс для видалення!");
            }
        }

        // Оновлення DataGridView
        private void UpdateDataGridView()
        {
            dgvRoutes.Rows.Clear();
            foreach (var route in routes)
            {
                dgvRoutes.Rows.Add(route.RouteNumber, route.Destination, string.Join(", ", route.Stops), route.DepartureTime, route.SeatsAvailable);
            }
        }

        // Кнопка "Вихід"
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchRoute_Click(object sender, EventArgs e)
        {
            // Запитуємо у користувача пункт призначення
            string searchDestination = Prompt.ShowDialog("Введіть пункт призначення:", "Пошук рейсу");

            // Перевірка, чи користувач ввів значення
            if (string.IsNullOrWhiteSpace(searchDestination))
            {
                MessageBox.Show("Будь ласка, введіть пункт призначення.", "Помилка");
                return;
            }

            // Пошук найближчого маршруту з урахуванням пункту призначення та наявності місць
            var availableRoute = routes
                .Where(route => route.Destination.Equals(searchDestination, StringComparison.OrdinalIgnoreCase)
                                || route.Stops.Any(stop => stop.Equals(searchDestination, StringComparison.OrdinalIgnoreCase)) // Шукаємо і серед проміжних зупинок
                                && route.SeatsAvailable > 0)
                .OrderBy(route => route.DepartureTime) // Сортуємо за часом відправлення
                .FirstOrDefault();

            // Перевіряємо, чи є доступний маршрут
            if (availableRoute != null)
            {
                MessageBox.Show($"Найближчий рейс до {searchDestination}:\n\n" +
                                $"Номер маршруту: {availableRoute.RouteNumber}\n" +
                                $"Пункт призначення: {availableRoute.Destination}\n" +
                                $"Час відправлення: {availableRoute.DepartureTime}\n" +
                                $"Доступні місця: {availableRoute.SeatsAvailable}",
                                "Результат пошуку");
            }
            else
            {
                MessageBox.Show($"Немає доступних рейсів до пункту {searchDestination}.", "Результат пошуку");
            }
        }

        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form()
                {
                    Width = 400,
                    Height = 150,
                    Text = caption
                };

                Label textLabel = new Label() { Left = 20, Top = 20, Text = text, Width = 350 };
                TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 350 };

                Button okButton = new Button() { Text = "OK", Left = 270, Width = 100, Top = 80 };
                okButton.Click += (sender, e) => { prompt.DialogResult = DialogResult.OK; prompt.Close(); };

                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(inputBox);
                prompt.Controls.Add(okButton);

                return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text : string.Empty;
            }
        }
        public class Ticket
        {
            public string PassengerName { get; set; }
            public string PassengerSurname { get; set; }
            public BusRoute SelectedRoute { get; set; }
            public bool HasDiscount { get; set; }
            public decimal DiscountAmount { get; set; }
        }

        private void btnBuyTicket_Click(object sender, EventArgs e)
        {
            
        }
        private void UpdateRouteTable()
        {
            // Оновлюємо дані таблиці
            dgvRoutes.DataSource = null;
            dgvRoutes.DataSource = routes;
        }


        private void btnReturnTicket_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Текстовий файл (*.txt)|*.txt",
                Title = "Збереження даних"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (var route in routes)
                    {
                        writer.WriteLine($"{route.RouteNumber};{route.Destination};{string.Join(",", route.Stops)};{route.DepartureTime};{route.SeatsAvailable}");
                    }
                }

                MessageBox.Show("Дані успішно збережено!", "Збереження");
            }
        }

        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Текстовий файл (*.txt)|*.txt",
                Title = "Завантаження даних"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    routes.Clear();

                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(';');
                        int routeNumber = int.Parse(parts[0]);
                        string destination = parts[1];
                        string[] stops = parts[2].Split(',');
                        DateTime departureTime = DateTime.Parse(parts[3]);
                        int seatsAvailable = int.Parse(parts[4]);

                        routes.Add(new LocalRoute(routeNumber, destination, stops, departureTime, seatsAvailable, 10)); // Локальний рейс як приклад
                    }
                }

                UpdateDataGridView();
                MessageBox.Show("Дані успішно завантажено!", "Завантаження");
            }
        }

        private void btnShowManifest_Click(object sender, EventArgs e)
        {
            

        }
        

    


    }

}
