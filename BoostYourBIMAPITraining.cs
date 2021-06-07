using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.ReadOnly)]
    public class WriteExcel : IExternalCommand
    {
        static AddInId appId = new AddInId(new Guid("A29E2523-6FEF-49B3-A25F-8EE18EBC0156"));
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            Document doc = commandData.Application.ActiveUIDocument.Document;

            string filepath = String.Format(@"{0}{1}", Path.GetTempPath(), "excelOutput.xlsx");
            using (ExcelPackage package = new ExcelPackage(new FileInfo(filepath)))
            {
                ExcelWorksheet sheet = package.Workbook.Worksheets.Add("My Exported Data");

                int row = 1;
                foreach (Element e in new FilteredElementCollector(doc).OfClass(typeof(Wall)))
                {
                    sheet.Cells[row, 1].Value = e.Name;
                    sheet.Cells[row, 2].Value = e.Id;

                    row++;
                }

                package.Save();

            }

            Process.Start(filepath);

            return Result.Succeeded;
        }
    }

    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class BasicForm : IExternalCommand
    {
        static AddInId appId = new AddInId(new Guid("1E6666BF-BBEC-4758-9221-2E10FC227AA2"));

        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {

            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;

            Element e = doc.GetElement(uidoc.Selection.PickObject(ObjectType.Element));

            double distance = 0;
            bool isHorizontal = false;
            using (myNewForm thisForm = new myNewForm())
            {
                thisForm.ShowDialog();
                if (thisForm.DialogResult == System.Windows.Forms.DialogResult.Cancel)
                {
                    return Result.Cancelled;
                }
                else
                {
                    distance = thisForm.getDistance();
                    isHorizontal = thisForm.isHorizontal();
                }
            }

            XYZ moveVector = null;
            if (isHorizontal)
            {
                moveVector = new XYZ(distance, 0, 0);
            }
            else
            {
                moveVector = new XYZ(0, distance, 0);
            }
            
            using (Transaction t = new Transaction(doc, "RSUtils - Move Object"))
            {
                t.Start();

                ElementTransformUtils.MoveElement(doc, e.Id, moveVector);

                t.Commit();
            }

            return Result.Succeeded;
        }
    }
}
