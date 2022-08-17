﻿using ITFCodeWA.ClientMudBlazor.Services.Api.Base.Interfaces;
using ITFCodeWA.Core.Models.Common.Base.Interfaces;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace ITFCodeWA.ClientMudBlazor.Components.EntityForms.Base
{
    public abstract class EntityFormView<TModel, TKey, TApiService> : ComponentBase
        where TModel : class, IModel<TKey>, new()
        where TApiService : class, IApiEntityCrudService<TModel, TKey>
        where TKey : IComparable
    {
        #region Protected Fields 

        protected MudForm _form;
        protected bool _success = false;
        protected bool _hasError = false;
        protected string _errorText = string.Empty;
        protected string[] _errors = { };
        protected bool _loading = true;

        #endregion

        #region Parameters

        [CascadingParameter]
        public MudDialogInstance MudDialog { get; set; }

        [Inject]
        public virtual TApiService ApiService { get; set; }

        [Parameter]
        public TKey ModelId { get; set; }

        //[Parameter]
        public TModel Model { get; set; }

        [Parameter]
        public EventCallback<TModel> SaveHandler { get; set; }

        #endregion

        #region Initialization 

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            await Task.Delay(500);

            if (ModelId is not null)
            {
                try
                {
                    Model = await ApiService.GetByIdAsync(ModelId);
                }
                catch (Exception ex)
                {
                    _hasError = true;
                }
            }
            else
            {
                Model = new();
            }

            _loading = false;
            StateHasChanged();
        }

        #endregion

        #region Protected Methods 

        protected async Task Save()
        {
            _hasError = false;
            if (SaveHandler.HasDelegate)
            {
                try
                {
                    await SaveHandler.InvokeAsync(Model);
                    CloseForm();
                }
                catch (Exception ex)
                {
                    _hasError = true;
                    _errorText = ex.Message;
                }
            }
            else
            {
                try
                {
                    await ApiService.AddAsync(Model);
                    CloseForm();
                }
                catch (Exception ex)
                {
                    _hasError = true;
                    _errorText = ex.Message;
                }
            }
        }

        protected void CloseForm()
        {
            MudDialog.Close(DialogResult.Ok(true));
        }

        #endregion
    }
}