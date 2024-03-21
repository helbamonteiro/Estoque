using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estoque
{
    public static class BindingSourceExtensions
    {
        public static void SuspendChanges(this BindingSource bindingSource)
        {
            bindingSource.SetUpdateMode(DataSourceUpdateMode.Never);
            
        }

        public static void ApplyChanges(this BindingSource bindingSource)
        {
            bindingSource.SetUpdateMode(DataSourceUpdateMode.OnPropertyChanged);
            bindingSource.EndEdit();
            bindingSource.SetUpdateMode(DataSourceUpdateMode.Never);
           
        }

        private static void SetUpdateMode(this BindingSource bindingSource, DataSourceUpdateMode updateMode)
        {
            foreach (Binding binding in bindingSource.CurrencyManager.Bindings)
            {
                binding.DataSourceUpdateMode = updateMode;
            }
        }
    }
}

