// See https://aka.ms/new-console-template for more information
using HtmlAgilityPack;
using static System.Net.WebRequestMethods;

class Program 
{
    static async Task Main(String[] args)
    {
        string url= "https://www.sbs.gob.pe/app/pp/sistip_portal/paginas/publicacion/tipocambiopromedio.aspx";
        using HttpClient cliente = new HttpClient();
        var response = await cliente.GetStringAsync(url);
        Console.WriteLine(response);

        if (response != null)
        {
            var html = new HtmlDocument();
            html.LoadHtml(response);
            
            var table = html.DocumentNode.SelectSingleNode("//table[@id='ctl00_cphContent_rgTipoCambio_ctl00']");
            var row = table.SelectSingleNode(".//tr[@id='ctl00_cphContent_rgTipoCambio_ctl00__0']");
            var nombreMoneda = row.SelectSingleNode(".//td[@class='APLI_fila3']");
            var montoMoneda = row.SelectNodes(".//td[@class='APLI_fila2']");
            var moneda = nombreMoneda.InnerText.Trim();
            var compra = montoMoneda[0].InnerText.Trim();
            var venta = montoMoneda[1].InnerText.Trim();
            Console.WriteLine($"Moneda: {moneda}");
            Console.WriteLine($"Compra: {compra}");
            Console.WriteLine($"Venta: {venta}");
        }
    }
}