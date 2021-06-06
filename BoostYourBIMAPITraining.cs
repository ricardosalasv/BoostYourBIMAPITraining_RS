using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoostYourBIMAPITraining
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.ReadOnly)]
    public class ShowADialog : IExternalCommand
    {
        static AddInId appId = new AddInId(new Guid("5FD6ED90-F4A8-4A64-804C-766F094E71F0"));

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            TaskDialog.Show("Hello", "I am an external command");
            return Result.Succeeded;
        }
    }

    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.ReadOnly)]
    public class ReadExcel : IExternalCommand
    {
        static AddInId appId = new AddInId(new Guid("D846F088-011D-4E83-8059-B095B31541B3"));

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elementSet)
        {
            string filename = "";
            System.Windows.Forms.OpenFileDialog openDialog = new System.Windows.Forms.OpenFileDialog();
            openDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            if (openDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = openDialog.FileName;
            }
            else
            {
                return Result.Cancelled;
            }

            string data = "";
            using (ExcelPackage package = new ExcelPackage(new System.IO.FileInfo(filename)))
            {
                ExcelWorksheet sheet = package.Workbook.Worksheets[0];
                for (int row = 1; row < 9999; row++)
                {
                    var thisValue = sheet.Cells[row, 1].Value;

                    if (thisValue == null || thisValue.ToString() == "")
                    {
                        break;
                    }

                    for (int col = 1; col < 999; col++)
                    {
                        thisValue = sheet.Cells[row, col].Value;

                        if (thisValue == null || thisValue.ToString() == "")
                        {
                            break;
                        }

                        data += thisValue.ToString() + ",";
                    }

                    data += "\n";
                }
            }

            TaskDialog.Show("Excel", data);

            return Result.Succeeded;
        }
    }
}
