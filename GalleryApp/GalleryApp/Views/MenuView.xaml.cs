using GalleryApp.Repositories;

namespace GalleryApp.Views;

public partial class MenuView : ContentPage
{
	public MenuView()
	{
		InitializeComponent();

		var categories = new CategoryRepository().GetCategories();

		foreach (var category in categories)
		{
			var lblCategory = new Label();
			lblCategory.Text = category.Name;

            MenuContainer.Children.Add(lblCategory);

            foreach (var component in category.Components)
			{
				var lblComponentTitle = new Label();
				lblComponentTitle.Text = component.Title;

				var lblComponentDescription = new Label();
				lblComponentDescription.Text = component.Description;

                MenuContainer.Children.Add(lblComponentTitle);
                MenuContainer.Children.Add(lblComponentDescription);
            }
		}
	}
}