namespace ShopWarehouse
{
    public class Reporting : IReporting
    {
    // Should we refactor these methods?
    // Do they really break DRY?
        public void ReportExport(IEnumerable<IReportable> itemsExported, IExporter from, IImporter to)
        {
            string startingMessage = $"Export Report for {DateTime.Today} for warehouse №{from.Id}:\n";
            StringBuilder finalReport = new StringBuilder(startingMessage);
            int counter = 1;
            foreach (var item in itemsExported)
            {
                finalReport.AppendLine($"{counter}. Exported: " + item.ToReportString());
                ++counter;
            }
            finalReport.Append($"In total exported {itemsExported.Count()} items from warehouse №{from.Id} to №{to.Id}.");
            Console.WriteLine(finalReport.ToString());
        }

        public void ReportImport(IEnumerable<IReportable> itemsImported, IImporter to, IExporter from)
        {
            string startingMessage = $"Import Report for {DateTime.Today} for warehouse №{to.Id}\n";
            StringBuilder finalReport = new StringBuilder(startingMessage);
            int counter = 1;
            foreach (var item in itemsImported)
            {
                finalReport.AppendLine($"{counter}. Imported: " + item.ToReportString());
                ++counter;
            }
            finalReport.Append($"In total imported {itemsImported.Count()} items to warehouse №{to.Id} from №{from.Id}");
        }
    }
}
