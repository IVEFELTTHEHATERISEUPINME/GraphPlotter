using System;
using System.Windows.Forms;

namespace GraphPlotter
{
    public partial class StartForm: Form
    {
        /// <summary>
        /// Стартовая форма с заданием на курсовую работу
        /// </summary>
        public StartForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик нажатия на пункт меню "№94"
        /// Открывает главную форму с построением графика
        /// </summary>
        private void btnOpenMainForm_Click(object sender, EventArgs e)
        {
            // Создаём и показываем главную форму
            MainForm mainForm = new MainForm();
            mainForm.Show();

            // Первая форма остаётся открытой, чтобы пользователь видел задание
        }
    }
}
