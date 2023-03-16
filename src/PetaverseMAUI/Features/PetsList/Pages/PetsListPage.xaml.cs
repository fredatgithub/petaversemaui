namespace PetaverseMAUI;

public partial class PetsListPage
{
	private PetsListPageViewModel viewModel;
    public PetsListPage(PetsListPageViewModel vm)
	{
		InitializeComponent();

		BindingContext = viewModel = vm;
    }

    private void BasePage_SizeChanged(object sender, EventArgs e)
    {
        if (Window.Width < 321)
        {
            if (viewModel is not null)
            {
                viewModel.Span = 1;
                return;
            }
        }
        if (Window.Width < 500)
        {
            if (viewModel is not null)
            {
                viewModel.Span = 2;
                return;
            }
        }
        else if (Window.Width < 900)
        {
            if (viewModel is not null)
            {
                viewModel.Span = 3;
                return;
            }
        }
        else if (Window.Width < 2000)
        {
            if (viewModel is not null)
            {
                viewModel.Span = 4;
                return;
            }
        }
    }

    private void PetHandler_SelectPet(PetProfileCardModel pet)
    {
		//PetsCollectionView.ScrollTo(pet, animate: true);
		viewModel.NavigateToProfileDetailCommand.Execute(pet);
    }
}