using ControlApp.Core.Entities;

namespace ControlApp;

public partial class ProductDetailsForm : Form
{
    private ProductEntity entity = null!;

    public event Action<ProductEntity>? OnEdit;
    public event Action<ProductEntity>? OnRemoved;

    public ProductDetailsForm()
    {
        InitializeComponent();
    }

    public ProductDetailsForm(ProductEntity entity)
        : this()
    {
        UpdateItem(entity);
        this.entity = entity;
    }

    private void UpdateItem(ProductEntity entity)
    {
        ProductSource.DataSource = entity;
        pictureBox1.Image = Image.FromFile(File.Exists(entity.ImageName) ?
            entity.ImageName : "defaultImage.jpg");
    }

    private void button3_Click(object sender, EventArgs e)
    {
        var copy = GetCopy(entity);

        var addEditForm = new ProductAddEditForm(copy);
        addEditForm.Text = "Редактировать товар";

        if (addEditForm.ShowDialog() == DialogResult.OK)
        {
            entity = addEditForm.ProductEntity;
            UpdateItem(entity);
            OnEdit?.Invoke(entity);
        }
    }


    private static ProductEntity GetCopy(ProductEntity entity)
    {
        return new ProductEntity
        {
            Category = entity.Category,
            Cost = entity.Cost,
            Count = entity.Count,
            Description = entity.Description,
            ImageName = entity.ImageName,
            Manufacturer = entity.Manufacturer,
            Name = entity.Name,
            Id = entity.Id,
        };
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Подтвердить удаление?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            == DialogResult.Yes)
        {
            OnRemoved?.Invoke(entity);
        }
    }
}
