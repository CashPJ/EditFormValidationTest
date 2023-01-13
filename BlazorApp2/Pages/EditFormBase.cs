using BlazorApp2.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace BlazorApp2.Pages
{
    public class EditFormBase : ComponentBase
    {
        protected ViewModel PageViewModel = new();
        protected EditContext PageEditContext { get; set; } = null!;

        protected override void OnInitialized()
        {
            PageViewModel.ModelDto = new ModelDtoCreate()
            {
                Description = "OnInitialized"
            };
            PageViewModel.ReasignEditContext = ReasignEditContext;


            PageEditContext = new EditContext(PageViewModel);
            base.OnInitialized();
        }

        protected void Edit()
        {
            PageViewModel.ModelDto = new ModelDtoEdit()
            {
                Description = "Edit"
            };
        }

        protected void Create()
        {
            PageViewModel.ModelDto = new ModelDtoCreate()
            {
                Description = "Create"
            };
        }

        protected void Validate()
        {
            PageEditContext.Validate();
        }

        private void ReasignEditContext()
        {
            PageEditContext = new EditContext(PageViewModel);
        }
    }
}
