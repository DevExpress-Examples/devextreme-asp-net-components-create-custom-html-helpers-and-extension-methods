using DevExtreme.AspNet.Mvc;
using DevExtreme.AspNet.Mvc.Builders;
using DevExtreme.AspNet.Mvc.Factories;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

public static class StaticSettings
{
    public static DataGridBuilder<T> SetDefaults<T>(this DataGridBuilder<T> grid)
    {
        grid.FocusedRowEnabled(true);
        grid.FocusedRowIndex(0);
        grid.GroupPanel(g => g.Visible(true));
        grid.SearchPanel(s => s.Visible(true));
        grid.ColumnAutoWidth(true);
        grid.ElementAttr(new { @class = "dx-card wide-card" });
        grid.ShowBorders(false);
        grid.FilterRow(f => f.Visible(true));
        grid.ColumnHidingEnabled(true);        
        return grid;
    }

    public static ButtonBuilder SetDefaults(this ButtonBuilder button) {
        button.Type(ButtonType.Success);
        button.Width(300);
        return button;
    }
    public static Action<DataGridPagerBuilder> DefaultPagerConfig = (builder) =>
    {
        builder.ShowPageSizeSelector(true);
        builder.AllowedPageSizes(new[] { 5, 10, 20 });
        builder.ShowInfo(true);
    };
    public static SelectBoxBuilder CustomLookupEditor(this ToolbarItemFactory toolbar, IHtmlHelper Html, string controllerName, string key,  string displayExpr)
    {
        SelectBoxBuilder lookup = Html.DevExtreme().SelectBox();
        lookup.DataSource(d => d.Mvc().Controller(controllerName).LoadAction("Get").Key(key));
        lookup.DisplayExpr(displayExpr);
        lookup.ValueExpr(key);
        return lookup;
    }
    public static void ConfigureColumns<T>(CollectionFactory<DataGridColumnBuilder<T>> columns, List<ColumnSettings> myColumns)
    {
        foreach (var def in myColumns)
        {
            columns.Add()
                .DataType(def.DataType)
                .DataField(def.Field)
                .Format(def.Format)
                .Caption(def.Caption);
        }
    }
    public static DataGridColumnBuilder<T> AddLookupConfig<T>(this DataGridColumnBuilder<T> column, string controllerName, string key, string displayExpr)
    {
        column.Lookup((lookup) =>
        {            
            lookup.DataSource(d => d.Mvc().Controller(controllerName).LoadAction("Get").Key(key));
            lookup.DisplayExpr(displayExpr);
            lookup.DataSourceOptions(o => o.Paginate(true).PageSize(10));
            lookup.ValueExpr(key);
        });
        column.HeaderFilter(hf => hf.AllowSearch(true));
        column.Width(200);
        return column;
    }
    public static DataGridColumnBuilder<T> AddActionColumn<T>(this DataGridColumnBuilder<T> column, IHtmlHelper Html)
    {
        var button = Html.DevExtreme().Button().StylingMode(ButtonStylingMode.Text).Text(new JS("value"));
        column.CellTemplate(String.Format("<text> <div><b>Row key is: <%= row.key %> </b> </div>{0}</text>", button.ToTemplate()));
        return column;
    }
}