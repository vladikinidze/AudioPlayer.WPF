﻿using System;
using AudioPlayer.WPF.ViewModels;

namespace AudioPlayer.WPF.Stores;

public class ModalNavigationStore
{
    public event Action CurrentViewModelChanged;
    

    private BaseViewModel _currentViewModel;
    public BaseViewModel CurrentViewModel
    {
        get => _currentViewModel;
        set
        {
            _currentViewModel?.Dispose();
            _currentViewModel = value;
            OnCurrentViewModelChanged();
        }
    }

    public bool IsOpen => CurrentViewModel != null!;

    public void Close()
    {
        CurrentViewModel = null!;
    }
    
    protected virtual void OnCurrentViewModelChanged()
    {
        CurrentViewModelChanged?.Invoke();
    }
}