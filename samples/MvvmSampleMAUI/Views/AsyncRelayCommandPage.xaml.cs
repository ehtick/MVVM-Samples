﻿using MvvmSample.Core.ViewModels;
using CommunityToolkit.Mvvm.DependencyInjection;

namespace MvvmSampleMAUI.Views;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class AsyncRelayCommandPage : BaseContentPage<AsyncRelayCommandPageViewModel>
{
    public AsyncRelayCommandPage(AsyncRelayCommandPageViewModel viewModel) : base(viewModel)
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        BindingContext.LoadDocsCommand.Execute("AsyncRelayCommand");
    }
}