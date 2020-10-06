using DevExtreme.AspNet.Mvc;
using DevExtreme.AspNet.Mvc.Builders;
using HtmlHelpersExtensions.Models;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HtmlHelpersExtensions.Helpers
{
    public static class HtmlHelpers
    {
        public static ButtonBuilder CustomButton(this IHtmlHelper Html, string ButtonText)
        {
            ButtonBuilder btn = Html.DevExtreme().Button().Text(ButtonText).Type(ButtonType.Success);
            return btn;
        }
        public static IHtmlContent CustomDateBoxFor<TModel, TProperty>(this IHtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, EditorApplyValueMode ApplyValueMode)
        {
            var res = htmlHelper.DevExtreme().DateBoxFor(expression).ApplyValueMode(ApplyValueMode).ToString();
            return new HtmlString(res);
        }
        public static IHtmlContent SynchronizedDateBoxes(this IHtmlHelper Html)
        {
            string startDateBox = Html.DevExtreme().DateBox().ID("startDate")
                .Value(DateTime.Now)
                .OnValueChanged("function(e){  var endDate= $('#endDate').dxDateBox('instance'); endDate.option('min', e.value);}")
                .ToString();
            string endDateBox = Html.DevExtreme().DateBox().ID("endDate")
                 .Value(DateTime.Now)
           
                 .OnValueChanged("function(e){  var startDate= $('#startDate').dxDateBox('instance'); endDate.option('max', e.value);}")
                .ToString();
            string res = startDateBox + endDateBox;
            return new HtmlString(res);
        }
    }
}
