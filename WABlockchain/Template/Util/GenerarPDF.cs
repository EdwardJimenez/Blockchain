using iText.Forms;
using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WABlockchain.Template.Util
{
    public class GenerarPDF
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public GenerarPDF()
        {
                
        }
        /// <summary>
        /// Metodo que Genera el Titulo en base a un Template diseñado, que se almacena en la carpeta Template.
        /// </summary>
        /// <param name="fullname"></param>
        /// <param name="carreer"></param>
        /// <returns>Ruta del TituloPDF Generado</returns>
        public string GenerarNuevoPDF(string fullname, string carreer)
        {
            string filePath = HttpContext.Current.Request.MapPath("~/Template/");

            string fileNameExisting = @"TITULOPROFESIONAL.pdf";

            string fileNameNew = "TITULOPROFESIONAL_" + fullname.Replace(" ", "").Trim() + ".pdf";

            string fullNewPath = filePath + fileNameNew;

            string fullExistingPath = filePath + fileNameExisting;

            using (var existingFileStream = new FileStream(fullExistingPath, FileMode.Open))

            using (var newFileStream = new FileStream(fullNewPath, FileMode.Create))
            {
                // Open existing PDF
                var reader = new PdfReader(existingFileStream);

                var write = new PdfWriter(newFileStream);

                PdfDocument pdfDocument = new PdfDocument(reader, write);

                PdfAcroForm form = PdfAcroForm.GetAcroForm(pdfDocument, false);

                form.GetField("TextFullName").SetValue(fullname);
                form.GetField("TextCarreer").SetValue(carreer);
                form.GetField("TextLincenciature").SetValue("Licenciatura");
                form.FlattenFields();
                pdfDocument.Close();
            }

            return fullNewPath;
        }
    }
}