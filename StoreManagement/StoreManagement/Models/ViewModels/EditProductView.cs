using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreManagement.Models.ViewModels
{
    public class EditProductView : CreateProductView
    {
        public int id { get; set; }
        public string imgPath { get; set; }
    }
}
