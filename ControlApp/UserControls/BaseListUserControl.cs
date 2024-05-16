using ControlApp.Core.Entities;
using ControlApp.Interfaces;

namespace ControlApp.UserControls;

public class BaseListUserControl<TEntity> : UserControl, IEntityListUserControl<TEntity>
    where TEntity : IEntity
{
    private DataGridView _dataGrid;

    protected void SetupDataGrid()
    {
        _dataGrid = ((DataGridView)Controls.Find("dataGridView1", false).First());
        this.Dock = DockStyle.Fill;
    }

    public int SelectedCount => _dataGrid.SelectedRows.Count;

    public IReadOnlyCollection<TEntity> SelectedEntities => _dataGrid.SelectedRows.Count > 0 ?
        _dataGrid
        .SelectedRows
        .OfType<DataGridViewRow>()
        .Select(row => (TEntity)row.DataBoundItem)
        .ToList() : [];

    public void SetupDataSource(IReadOnlyCollection<TEntity> entities)
    {
        _dataGrid.DataSource = entities;
    }
}