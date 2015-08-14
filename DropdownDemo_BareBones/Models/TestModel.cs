using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropdownDemo_BareBones.Models
{
    public class TestModel
    {
        public string Gender { get; set; }

        public IEnumerable<SelectListItem> GenderList
        {
            get
            {
                List<SelectListItem> list = new List<SelectListItem> { new SelectListItem() { Text = "Select", Value = "Select" }, new SelectListItem() { Text = "Male", Value = "Male" }, new SelectListItem() { Text = "Female", Value = "Female" }, new SelectListItem() { Text = "Other", Value = "Other" } };
                return list.Select(l => new SelectListItem { Selected = (l.Value == Gender), Text = l.Text, Value = l.Value });
            }
        }
    }
}