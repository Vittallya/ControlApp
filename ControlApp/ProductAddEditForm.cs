using ControlApp.Core.Entities;

namespace ControlApp;

public partial class ProductAddEditForm : Form
{
    public ProductEntity ProductEntity { get; } = null!;

    public ProductAddEditForm()
    {
        InitializeComponent();
    }

    public ProductAddEditForm(ProductEntity entity)
        : this()
    {
        ProductEntity = entity;
        bindingSource1.DataSource = entity;
    }

    private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        if(ProductEntity.Count < 0)
        {
            MessageBox.Show("Количество товара не может быть меньше 0");
            return;
        }

        DialogResult = DialogResult.OK;
    }

    private void textBox7_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox7_Click(object sender, EventArgs e)
    {
        var form = new OpenFileDialog
        {
            Multiselect = false,
            CheckFileExists = true,
            CheckPathExists = true,
        };

        if(form.ShowDialog() == DialogResult.OK)
        {
            ProductEntity.ImageName = form.FileName;
            textBox7.Text = form.FileName;
        }
    }
}
