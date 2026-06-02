using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace GraphPlotter
{
    /// <summary>
    /// Главная форма программы для построения графика функции y = (x-2)²
    /// </summary>
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
            // Подписываемся на событие закрытия формы для корректного завершения приложения
            FormClosed += MainForm_FormClosed;
        }

        /// <summary>
        /// Обработчик кнопки "Построить график"
        /// Вычисляет координаты точек, выводит в ListBox и строит график
        /// </summary>
        private void BtnBuildGraph_Click(object sender, EventArgs e)
        {
            const double startX = 0.9, endX = 4.1, step = 0.2; // Параметры функции (фиксированы по заданию)

            // Вычисляем количество точек
            int pointCount = (int)Math.Round((endX - startX) / step) + 1;

            // Очищаем ListBox от предыдущих результатов
            listBoxPoints.Items.Clear();

            // Создаём массивы для хранения координат
            double[] xValues = new double[pointCount];
            double[] yValues = new double[pointCount];
            
            // Вычисляем координаты
            for (int i = 0; i < pointCount; i++)
            {
                xValues[i] = startX + i * step;
                yValues[i] = (xValues[i] - 2) * (xValues[i] - 2);

                // Выводим координаты в ListBox с форматированием до 2 знаков после запятой
                listBoxPoints.Items.Add($"x = {xValues[i]:F2};   y = {yValues[i]:F2}");
            }

            // Строим график
            chartGraph.Series[0].Points.DataBindXY(xValues, yValues);
            
            // Активируем кнопку сохранения
            btnSaveFile.Enabled = true;
        }

        /// <summary>
        /// Обработчик кнопки "Записать в файл"
        /// Сохраняет координаты точек в выбранный текстовый файл
        /// </summary>
        private void BtnSaveFile_Click(object sender, EventArgs e)
        {
            // Настройка диалога сохранения файла
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";  // Только .txt
            saveFileDialog.Title = "Сохранить координаты";

            // Если пользователь выбрал файл и нажал "Сохранить"
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Записываем все строки из ListBox в файл
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (string st in listBoxPoints.Items)
                        {
                            writer.WriteLine(st);
                        }
                    }

                    // Уведомляем об успешном сохранении
                    MessageBox.Show("Данные успешно сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Обработка любых ошибок
                    MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Обработчик закрытия главной формы
        /// Полностью завершает приложение, чтобы не оставалось фоновых процессов
        /// </summary>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
