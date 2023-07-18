using System.Text.Json;

namespace demo1;

class Report {
    int page;
    int per_page;
    int total;
    int total_pages;
    data data;
}

class data {
    string  name;
    string weather;
    List<status> status;
}

class status {
    string Wind;
    string Humidity;
}


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

         HttpClient client = new HttpClient();
        var apiUrl = string.Format("https://jsonmock.hackerrank.com/api/weather/search?name={0}", "all");
        
        var result = client.GetAsync(apiUrl).Result;
        var report = result.Content.ReadAsStringAsync().Result;
        var res = JsonConvert.DeserializeObject<Report>(report);
        Report reportData = JsonSerializer.Deserialize<Report>(report);
        Console.WriteLine(reportData.);

        // int[] i = {1, -2, 3, 0, -4, 5};

        // var pos = from n in i where n % 2 == 0 select n;

        // foreach(int j in pos){
        //     Console.Write(j + " ");
        // }

        // Console.WriteLine("{0}, {0}", 10, 20);
        // var test = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine(test);


    }
}
