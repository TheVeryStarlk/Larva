﻿using System;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Larva.Avalonia.ViewModels;

public sealed partial class MenuViewModel : ObservableObject
{
    [RelayCommand]
    private Task CreateAsync()
    {
        throw new NotImplementedException();
    }

    [RelayCommand]
    private Task OpenAsync()
    {
        throw new NotImplementedException();
    }

    [RelayCommand]
    private void Exit()
    {
        Environment.Exit(0);
    }
}