using ControlApp.Core.Entities;

namespace ControlApp.UserControls;

public partial class ProductReturnList : BaseListUserControl<ProductReturnEntity>
{
    public ProductReturnList()
    {
        InitializeComponent();
        SetupDataGrid();
    }
}
