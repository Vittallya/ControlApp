using ControlApp.Core.Entities;

namespace ControlApp;

public partial class ProductItem : UserControl
{
    public ProductItem()
    {
        InitializeComponent();
    }

    public ProductItem(ProductEntity product)
        : this()
    {
        UpdateProduct(product);
    }

    public void UpdateProduct(ProductEntity product)
    {
        productBS.DataSource = product;
        pictureBox1.Image = Image.FromFile(File.Exists(product.ImageName) ?
            product.ImageName : "defaultImage.jpg");
    }

    private void ProductItem_Click(object sender, EventArgs e)
    {
        OnClick(e);
    }
}
