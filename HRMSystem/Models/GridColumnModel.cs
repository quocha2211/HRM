using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Models
{
    public class GridColumnModel
    {
        public string Name { get; set; }
        public string FieldName { get; set; }
        public string Caption { get; set; }
        public string DisplayFormat { get; set; }
        public bool Visible { get; set; }
        public FixedStyle Frozen = FixedStyle.None;
    }
}
