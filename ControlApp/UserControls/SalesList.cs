using ControlApp.Core.Entities;

namespace ControlApp.UserControls;

public partial class SalesList : BaseListUserControl<ProductSaleEntity>
//public partial class SalesList : UserControl
{
    public SalesList()
    {
        InitializeComponent();
        SetupDataGrid();
    }
}
