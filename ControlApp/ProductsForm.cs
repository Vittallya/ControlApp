using ControlApp.Core.Entities;
using ControlApp.Extensions;

namespace ControlApp;

public partial class ProductsForm : Form
{
    private readonly IProductsRepository _productsRepository = null!;
    private System.Windows.Forms.Timer _timer = null!;

    public ProductsForm()
    {
        InitializeComponent();
    }

    public ProductsForm(IProductsRepository productsRepository)
        : this()
    {
        this._productsRepository = productsRepository;
    }

    private async void ProductsForm_Load(object sender, EventArgs e)
    {
        var products = await _productsRepository.GetProducts();
        LoadProducts(products);
    }

    private void LoadProducts(IReadOnlyCollection<ProductEntity> products)
    {
        flowLayoutPanel1.Controls.Clear();

        foreach (var product in products)
        {
            flowLayoutPanel1.Controls.Add(CreateProductItem(product));
        }
    }

    private ProductItem CreateProductItem(ProductEntity product)
    {
        var productItem = new ProductItem(product);
        productItem.Click += (a, b) => OnProductItemClick(product.Id, productItem, flowLayoutPanel1);
        return productItem;
    }

    ProductDetailsForm? detailsForm;

    private async void OnProductItemClick(int productId, ProductItem item, FlowLayoutPanel panel)
    {
        var product = await _productsRepository.GetById(productId);
        detailsForm = new ProductDetailsForm(product!);
        detailsForm.OnRemoved += async entity =>
        {
            await _productsRepository.DeleteProduct(entity.Id);
            detailsForm.Close();
            panel.Controls.Remove(item);
        };

        detailsForm.OnEdit += async entity =>
        {
            await _productsRepository.UpdateProduct(entity);
            item.UpdateProduct(entity);
        };
        detailsForm.Show(this);
    }

    private async void button3_Click(object sender, EventArgs e)
    {
        var addEditForm = new ProductAddEditForm(new ProductEntity()
        {
            Category = "Категория",
            Cost = 0,
            Count = 1,
            Description = "Описание",
            ImageName = "Изображение.формат",
            Manufacturer = "Производитель",
            Name = "Наименование"
        });
        addEditForm.Text = "Добавить товар";

        if (addEditForm.ShowDialog() == DialogResult.OK)
        {
            int id = await _productsRepository.AddProduct(addEditForm.ProductEntity);
            var entityWithId = addEditForm.ProductEntity with { Id = id };
            flowLayoutPanel1.Controls.Add(CreateProductItem(entityWithId));
        }
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        _timer?.Stop();
        _timer?.Dispose();

        _timer = new System.Windows.Forms.Timer()
        {
            Interval = 250,
            Enabled = true,
        };

        var searchStr = textBox1.Text;
        var isEmpty = string.IsNullOrEmpty(searchStr);
        _timer.Tick += async (a, b) =>
        {
            LoadProducts(isEmpty ?
                await _productsRepository.GetProducts() :
                await _productsRepository.GetProducts(new ProductFilter() { SearchString = searchStr }));
            _timer.Stop();
            _timer.Dispose();
        };
        _timer.Start();
    }

    //private async Task WaitAndExecuteAsync(int millisecondsDelay, CancellationToken token, Func<Task> executeFunc)
    //{
    //    try
    //    {
    //        await Task.Delay(millisecondsDelay, token);
    //        await executeFunc();
    //    }
    //    catch (TaskCanceledException)
    //    {
    //        return;
    //    }
    //}

    private void button1_Click(object sender, EventArgs e)
    {
        this.ChangeForm<MainForm>();
    }
}
