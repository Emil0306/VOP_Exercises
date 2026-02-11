using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Ciphers.Ciphers;

public partial class MainWindow : Window
{
    
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private void Spinner_OnSpin(object? sender, SpinEventArgs e)
    {
        int spinnerContent = Int32.Parse(Spinner.Content!.ToString()!);
        switch (e.Direction)
        {
            case SpinDirection.Decrease:
                if (spinnerContent > 0)
                {
                    Spinner.Content = spinnerContent - 1;
                    
                }
                break;
            case SpinDirection.Increase:
                if (spinnerContent < AbstractCipher.Alphabet.Length / 2)
                {
                    Spinner.Content = spinnerContent + 1;
                }
                break;
        }
    }
}