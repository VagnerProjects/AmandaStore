using AmandaStore.Domain.Entitys;
using Microsoft.AspNetCore.Http;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AmandaStore.Services.Excel
{
    public class ImportarProdutos
    {
        public List<Produto> _extratorProduto;

        public List<Produto> Extrair(IFormFile file)
        {
            try
            {
                using (var memoryStream = new MemoryStream())
                {
                    var stream = file.OpenReadStream();
                    stream.CopyTo(memoryStream);

                    ExcelPackage.LicenseContext = LicenseContext.Commercial;

                    using (var package = new ExcelPackage())
                    {
                        var totalRows = package.Workbook.Worksheets["Produtos"].Dimension?.Rows;

                        for(int i = 0; i < totalRows; i++)
                        {

                        }
                    }
                }
            }
            catch(Exception ex)
            {

            }

            return _extratorProduto;
        }
    }
}
