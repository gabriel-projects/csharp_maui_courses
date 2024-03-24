using GalleryApp.Models;
using GalleryApp.Views.Layouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalleryApp.Repositories
{
    public class CategoryRepository
    {
        public CategoryRepository()
        {
            
        }

        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>
            {
                new Category
                {
                    Name = "Layout",
                    Components = new List<Component>
                    {
                        new Component
                        {
                            Title = "StackLayout",
                            Description = "Sequential organization of elements",
                            Type = typeof(StackLayoutPage)
                        },
                        new Component
                        {
                            Title = "GridLayout",
                            Description = "Organize elements inside from table",
                            Type = typeof(GridLayoutPage)
                        },
                        new Component
                        {
                            Title = "AbsolutLayout",
                            Description = "",
                            Type = typeof(AbsolutLayoutPage)
                        }
                    }
                }
            };

            return categories;
        }
    }
}
