using ControlApp.Core.Entities;

namespace ControlApp.UserControls;

public partial class ProductsIncomeDataGrid : BaseListUserControl<ProductIncomeEntity>
//public partial class ProductsIncomeDataGrid : UserControl
{
    public ProductsIncomeDataGrid()
    {
        InitializeComponent();
        SetupDataGrid();
    }
}
