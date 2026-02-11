using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Polymorphism.Polymorphism;

public partial class MainWindow : Window
{
    public MainWindow() 
    {
        InitializeComponent();
        RadioEllipse.Content = ShapeFacade.Shapes.Ellipse;
        RadioRectangle.Content = ShapeFacade.Shapes.Rectangle;
        RadioCircle.Content = ShapeFacade.Shapes.Circle;
        RadioSquare.Content = ShapeFacade.Shapes.Square;
    }
    
    private void RadioButtonHandler(object? sender, RoutedEventArgs e)
    {
        TextBoxNumber1.IsVisible = true;
        var rb = sender as RadioButton;
        if (rb?.IsChecked != true)
            return; // Ignore the "unchecked" event
        ShapeFacade.Shapes _selectedShape = (ShapeFacade.Shapes)(sender as RadioButton).Content;
        switch (_selectedShape)
        {
            case ShapeFacade.Shapes.Ellipse:
                TextBoxNumber2.IsVisible = true;
                break;
            case ShapeFacade.Shapes.Rectangle:
                TextBoxNumber2.IsVisible = true;
                break;
            case ShapeFacade.Shapes.Circle:
                TextBoxNumber2.IsVisible = false;
                break;
            case ShapeFacade.Shapes.Square:
                TextBoxNumber2.IsVisible = false;
                break;
        }
    }

    private void GetInfo_Click(object sender, RoutedEventArgs e)
    {
        ShapeFacade.Shapes _selectedShape;
        if (RadioEllipse.IsChecked == true) _selectedShape = ShapeFacade.Shapes.Ellipse;
        else if (RadioRectangle.IsChecked == true) _selectedShape = ShapeFacade.Shapes.Rectangle;
        else if (RadioCircle.IsChecked == true) _selectedShape = ShapeFacade.Shapes.Circle;
        else if (RadioSquare.IsChecked == true) _selectedShape = ShapeFacade.Shapes.Square;
        else
        {
            TextBlockResult.Text = "No shape selected"; 
            return;
        }
        if (_selectedShape == ShapeFacade.Shapes.Ellipse || _selectedShape == ShapeFacade.Shapes.Rectangle)
        {
            if (double.TryParse(TextBoxNumber1.Text, out double t1) && double.TryParse(TextBoxNumber2.Text, out double t2))
            {
                TextBlockResult.Text = ShapeFacade.GetInstance.GetShapeInfo(_selectedShape, t1, t2);
            }
            else
            {
                TextBlockResult.Text = "Numbers not valid";
            }
        }
        else if (_selectedShape ==  ShapeFacade.Shapes.Circle || _selectedShape == ShapeFacade.Shapes.Square)
        {
            if (double.TryParse(TextBoxNumber1.Text, out double t1))
            {
                TextBlockResult.Text = ShapeFacade.GetInstance.GetShapeInfo(_selectedShape, t1);
            }
            else
            {
                TextBlockResult.Text = "Numbers not valid";
            }
        }
        
    }
    
}