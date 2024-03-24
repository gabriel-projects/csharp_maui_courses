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
                            Description = "total freedom to position and size elements on the screen",
                            Type = typeof(AbsolutLayoutPage)
                        },
                        new Component
                        {
                            Title = "FlexLayout",
                            Description = "organizes the elements sequentially and has a lot of customization",
                            Type = typeof(FlexLayoutPage)
                        }
                    }
                }
            };

            return categories;
        }
    }
}
