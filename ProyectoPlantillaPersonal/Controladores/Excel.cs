using System;
using System.Collections.Generic;
using Microsoft.Office.Interop.Excel;

namespace ProyectoPlantillaPersonal.Controladores
{
    internal class Excel
    {
        public Excel(String ruta, Boolean visible)
        {
            abrirExcel(ruta, visible);
        }

        public Excel()
        {
        }

        public String ruta { get; set; }
        public Application application { get; set; }
        public Workbooks workBooks { get; set; }
        public Workbook workBook { get; set; }
        public Worksheet workSheet { get; set; }
        public Range range { get; set; }

        private void abrirExcel(String ruta, Boolean visible)
        {
            // Creamos un objeto Excel.
            application = new Application();
            application.Visible = visible;
            workBooks = application.Workbooks;
            workBook = workBooks.Open(ruta);
            workSheet = (Worksheet)workBook.Worksheets.get_Item(1);
            range = workSheet.UsedRange;
        }
        public int contarDatos(string ruta)
        {
            abrirExcel(ruta, false);
            int cont = ((range.Cells as Range).Rows.Count);
            application.Quit();

            releaseObject(application);
            releaseObject(range);
            releaseObject(workSheet);
            return cont;
        }

        public List<List<String>> obtenerDatos(String ruta, Boolean visible)
        {
            abrirExcel(ruta, visible);
            List<List<String>> listaDatos = new List<List<string>>();
            List<String> datos;

            Console.WriteLine("" + ((range.Cells as Range).Columns.Count));
            Console.WriteLine("" + ((range.Cells as Range).Rows.Count));

            for (int i = 1; i <= ((range.Cells as Range).Rows.Count); i++)
            {
                datos = new List<String>();

                for (int j = 1; j <= ((range.Cells as Range).Columns.Count); j++)
                {
                    
                    datos.Add((range.Cells[i, j] as Range).Value + "");
                }
                listaDatos.Add(datos);
            }
            application.Quit();
            
            releaseObject(application);
            releaseObject(range);
            releaseObject(workSheet);
            return listaDatos;
        }

        public void cargarDatos(List<List<String>> listaDatos)
        {
            Application application = new Application();
            application.Visible = true;
            Workbook workBook = application.Workbooks.Add();
            Worksheet workSheet = workBook.Worksheets[1];
            Range range = workSheet.UsedRange;
            System.Windows.Forms.MessageBox.Show(listaDatos.Count+"");
            for (int i = 1; i <= listaDatos.Count; i++)
            {
                for (int j = 1; j <= listaDatos[0].Count; j++)
                {
                    
                    application.Cells[i, j] = listaDatos[i - 1][j - 1];
                }
            }
            application.Quit();
            releaseObject(workBook);  
            releaseObject(application);
            releaseObject(range);
            releaseObject(workSheet);
        }

        public void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to release the object(object:{0})", obj.ToString());
            }
            finally
            {
                obj = null;
                GC.Collect();
            }
        }
    }
}