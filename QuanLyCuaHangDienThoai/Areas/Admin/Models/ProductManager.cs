using QuanLyCuaHangDienThoai.Models.DAO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace QuanLyCuaHangDienThoai.Areas.Admin.Models
{
    public class ProductManager
    {
        public ListProduct Insert { get; set; }
        public ListProduct Update { get; set; }
        public HttpPostedFileWrapper ImageGet { get; set; }
        public void InsertProduct(ProductManager model)
        {
            if (model.ImageGet != null)
            {
                model.Insert.Image = GetByteArray(model.ImageGet);
            }
            new ModifierSP().Insert(model.Insert);
        }
        public void UpdateProduct(ProductManager model)
        {
            if (model.ImageGet != null)
            {
                model.Update.Image = GetByteArray(model.ImageGet);
            }
            new ModifierSP().Update(model.Update);
        }
        public byte[] GetByteArray(HttpPostedFileWrapper file)
        {
            var files = file;
            byte[] imagebyte = null;
            BinaryReader reader = new BinaryReader(files.InputStream);
            imagebyte = reader.ReadBytes(files.ContentLength);
            return imagebyte;
        }
    }
}