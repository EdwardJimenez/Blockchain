﻿using iText.Forms;
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
        public GenerarPDF()
        {
                
        }

        public string GenerarNuevoPDF(string fullname, string carreer)
        {
            string filePath = @"D:\Taller Inf2\Versionamiento\Blockchain\WABlockchain\Template\";

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