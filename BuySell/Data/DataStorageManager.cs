using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using BuySell.Services;

namespace BuySell.Data
{
    public static class DataStorageManager
    {
        private const string FilePath = "exchange_database.json";

        public static void SaveData(ExchangeService service)
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(service, options);
                File.WriteAllText(FilePath, jsonString);
            }
            catch (Exception)
            {
                MessageBox.Show("Не вдалося зберегти дані на диск. Перевірте права доступу до папки.",
                                "Помилка збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static ExchangeService LoadData()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    string jsonString = File.ReadAllText(FilePath);
                    var service = JsonSerializer.Deserialize<ExchangeService>(jsonString);
                    return service ?? new ExchangeService();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Файл бази даних пошкоджено або має невірний формат. Буде створено нову порожню базу.",
                                "Помилка завантаження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return new ExchangeService(); // Якщо файлу немає або сталася помилка, повертаємо чистий сервіс
        }
    }
}