using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Common.Infrastructure.DBAL.Types
{
    public abstract class ModelType : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual Type GetModelType()
        {
            return GetType();
        }

        public static string GetTableName(Type model)
        {
            var attribute = model.GetTypeInfo().GetCustomAttributes(typeof(TableAttribute)).FirstOrDefault();
            var tableAttribute = attribute as TableAttribute;

            return tableAttribute != null ? tableAttribute.Name : "";
        }
    }
}