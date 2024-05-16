using ControlApp.Core.Entities;
using ControlApp.Interfaces;
using ControlApp.UserControls;
using Microsoft.Extensions.DependencyInjection;

namespace ControlApp.Abstract;

public partial class DetailForm : Form
{
    public IEntity Entity { get; private set; } = null!;

    public DetailForm()
    {
        InitializeComponent();
    }

    public void SetupForEntity<TEntity>(TEntity entity)
        where TEntity : IEntity
    {
        Entity = entity;
        var userControl = Program.ServiceProvider.GetRequiredService<IEntityUserControl<TEntity>>();
        userControl.SetupEntity(entity);
        panel1.Controls.Add((Control)userControl);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.OK;
    }
}
