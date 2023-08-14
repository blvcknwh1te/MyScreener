using Newtonsoft.Json;
using System.Net.Http;


namespace MyScreener
{
    enum Operation
    {
        GreaterThan,
        LessThan,
        Equal
    }

    class StateMachine
    {
        private readonly Operation operation;

        public StateMachine(Operation operation)
        {
            this.operation = operation;
        }

        public bool IsGreater(double a, double b) => a > b;
        public bool IsLess(double a, double b) => a < b;
        public bool IsEqual(double a, double b) => a == b;

        public bool IsStockPassingFilter(double a, double b)
        {
            return operation switch
            {
                Operation.GreaterThan => IsGreater(a, b),
                Operation.LessThan => IsLess(a, b),
                Operation.Equal => IsEqual(a, b),
                _ => throw new ArgumentException("Invalid operation selected.")
            };
        }
    }


    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 


        static void RunApp()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        [STAThread]
        static async Task Main()
        {
            string apiKey = "T72G7ZUWOWCGQOPH"; // API ключ от Alpha Vantage
            string url = $"https://www.alphavantage.co/query?function=TIME_SERIES_INTRADAY&symbol=MSFT&interval=1min&apikey={apiKey}";


            RunApp();


            //using (HttpClient client = new HttpClient())
            //{
            //    try
            //    {
            //        HttpResponseMessage response = await client.GetAsync(url);
            //        if (response.IsSuccessStatusCode)
            //        {
            //            string content = await response.Content.ReadAsStringAsync();
            //            var data = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(content);
            //            var timeSeries = data["Time Series (1min)"];

            //            List<Stock> stocks = new List<Stock>();
            //            foreach (var kvp in timeSeries)
            //            {
            //                DateTime date = DateTime.ParseExact(kvp.Key, "yyyy-MM-dd HH:mm:ss", null);
            //                double price;
            //                int volume;

            //                if (double.TryParse(kvp.Value["4. close"], out price) &&
            //                    int.TryParse(kvp.Value["5. volume"], out volume))
            //                {
            //                    stocks.Add(new Stock
            //                    {
            //                        Symbol = "MSFT",
            //                        Price = price,
            //                        Volume = volume,
            //                        Date = date,
            //                        CompanyName = "Microsoft"
            //                    });
            //                }
            //            }

            //            // Ввод символа акции, которую нужно найти
            //            Console.Write("Введите символ акции для поиска: ");
            //            string searchSymbol = Console.ReadLine();

            //            // Поиск акций по символу
            //            List<Stock> searchResults = stocks.FindAll(stock => stock.Symbol == searchSymbol);

            //            if (searchResults.Count > 0)
            //            {
            //                Console.WriteLine("Результаты поиска:");
            //                foreach (var result in searchResults)
            //                {
            //                    Console.WriteLine($"Symbol: {result.Symbol}, Price: {result.Price}, Volume: {result.Volume}, Date: {result.Date}, Company: {result.CompanyName}");
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Акции с данным символом не найдены.");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Ошибка при получении данных от API.");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Ошибка: " + ex.Message);
            //    }
            //}
        }
    }
}