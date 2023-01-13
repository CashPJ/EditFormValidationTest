using BlazorApp2.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.Models
{
    public class ViewModel
    {
        private IModelDto _modelDto = new ModelDtoCreate() { Description = "Default" };

        [ValidateComplexType]
        public IModelDto ModelDto 
        {
            get => _modelDto;
            set
            {
                _modelDto= value;

                if (AutoReasignEditContext)
                    ReasignEditContext?.Invoke();
            }
        }

        public bool AutoReasignEditContext { get; set; }
        public Action? ReasignEditContext { get; set; }
    }
}
