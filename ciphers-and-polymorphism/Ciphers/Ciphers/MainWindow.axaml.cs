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
    
    private void Encrypt_Click(object sender, RoutedEventArgs e)
    {
        if (Caesar.IsChecked == true)
        {
            CaesarCipher caesar = new CaesarCipher(Int32.Parse(Spinner.Content!.ToString()!));
            EncryptLabel.Content = caesar.Encrypt(MessageTextBox.Text);
        }
        else if (Atbash.IsChecked == true)
        {
            AtbashCipher atBash = new AtbashCipher();
            EncryptLabel.Content = atBash.Encrypt(MessageTextBox.Text);
        }
    }

    private void Decrypt_Click(object sender, RoutedEventArgs e)
    {
        if (Caesar.IsChecked == true)
        {
            CaesarCipher caesar = new CaesarCipher(Int32.Parse(Spinner.Content!.ToString()!));
            DecryptLabel.Content = caesar.Decrypt(MessageTextBox.Text);
        }
        else if (Atbash.IsChecked == true)
        {
            AtbashCipher atBash = new AtbashCipher();
            DecryptLabel.Content = atBash.Decrypt(MessageTextBox.Text);
        }
    }
}