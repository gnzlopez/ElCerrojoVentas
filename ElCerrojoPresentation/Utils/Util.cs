using ElCerrojoServices.DTOs;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace ElCerrojoPresentation.Utils
{
    public static class Util
    {
        public static Bitmap resLogo = Properties.Resources.Logo;
        public static string resColor = Properties.Resources.Color;

        public static byte[] GenerateSalePDF(SaleDto sale, Stream imageLogo)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            var arrayPDF = Document.Create(document =>
            {
                document.Page(page =>
                {
                    page.Margin(30);
                    page.Header().ShowOnce().Row(row =>
                    {
                        var imagebyte = (byte[])new ImageConverter().ConvertTo(resLogo, typeof(byte[]));

                        if (imagebyte != null)
                        {
                            row.AutoItem().Height(60).Image(imagebyte);
                        }

                        row.RelativeItem().Column(col =>
                        {
                            col.Item().AlignCenter().Text("El Cerrojo").Bold().FontSize(14);
                            col.Item().AlignCenter().Text("Urquiza 6698, Rosario, Santa Fe").FontSize(9);
                            col.Item().AlignCenter().Text("0341 676-4416").FontSize(9);
                        });

                        row.ConstantItem(140).Column(col =>
                        {
                            col.Item().Border(1).BorderColor(resColor).AlignCenter().Text($"");
                            col.Item().Background(resColor).Border(1).BorderColor(resColor).AlignCenter().Text($"Venta");
                            col.Item().Border(1).BorderColor(resColor).AlignCenter().Text($"{sale.Id:00000000}");
                        });
                    });

                    page.Content().PaddingVertical(15).Column(col1 =>
                    {
                        col1.Spacing(10);
                        col1.Item().LineHorizontal(0.5f);
                        col1.Item().Row(row =>
                        {
                            row.RelativeItem().Text(txt =>
                            {
                                txt.Span("Fecha:").SemiBold().FontSize(10);
                                txt.Span(sale.Date.ToShortDateString()).FontSize(10);
                            });
                        });

                        col1.Item().LineHorizontal(0.5f);

                        col1.Item().Table(table =>
                        {
                            table.ColumnsDefinition(col => 
                            {
                                col.RelativeColumn(3);
                                col.RelativeColumn();
                                col.RelativeColumn();
                                col.RelativeColumn();
                            });

                            table.Header(header =>
                            {
                                header.Cell().Background(resColor).Padding(2).Text("Producto");
                                header.Cell().Background(resColor).Padding(2).Text("Precio");
                                header.Cell().Background(resColor).Padding(2).Text("Cantidad");
                                header.Cell().Background(resColor).Padding(2).Text("Total");
                            });

                            foreach (SaleDetailDto det in sale.Details)
                            {
                                table.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).Text(det.ProductName).FontSize(10);
                                table.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).Text($"$ {det.SalePrice.ToString("0.00")}").FontSize(10);
                                table.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).Text($"{det.Quantity}").FontSize(10);
                                table.Cell().BorderBottom(0.5f).BorderColor("#D9D9D9").Padding(2).Text($"$ {det.TotalPrice.ToString("0.00")}").FontSize(10);
                            }
                        });

                        col1.Item().AlignRight().Text($"$ {sale.TotalPrice.ToString("0.00")}").FontSize(10);
                    });

                    page.Footer().AlignRight().Text(txt =>
                    {
                        txt.Span("Pagina").FontSize(10);
                        txt.CurrentPageNumber().FontSize(10);
                        txt.Span(" de ").FontSize(10);
                        txt.TotalPages().FontSize(10);
                    });
                });
            }).GeneratePdf();

            return arrayPDF;
        }
    }
}
