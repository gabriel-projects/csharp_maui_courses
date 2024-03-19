using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalleryApp.Models
{
    public class Component
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Type Type { get; set; }
        public bool IsReplaceMainPage { get; set; } = false;
    }
}
