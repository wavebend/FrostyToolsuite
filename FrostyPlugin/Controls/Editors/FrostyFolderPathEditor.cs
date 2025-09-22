using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Ookii.Dialogs.Wpf;

namespace Frosty.Core.Controls.Editors
{
    public class FrostyFolderPathEditor : FrostyTypeEditor<FrostyFolderPathControl>
    {
        public FrostyFolderPathEditor()
        {
            ValueProperty = FrostyFolderPathControl.TextProperty;
        }
    }

    [TemplatePart(Name = PART_BrowseButton, Type = typeof(Button))]
    [TemplatePart(Name = PART_OpenButton, Type = typeof(Button))]
    [TemplatePart(Name = PART_ClearButton, Type = typeof(Button))]
    public class FrostyFolderPathControl : Control
    {
        private const string PART_BrowseButton = "PART_BrowseButton";
        private const string PART_OpenButton = "PART_OpenButton";
        private const string PART_ClearButton = "PART_ClearButton";
        
        private Button browseButton;
        private Button openButton;
        private Button clearButton;

        #region -- Properties --

        #region -- Text --
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(nameof(Text), typeof(string), typeof(FrostyFolderPathControl), new FrameworkPropertyMetadata(""));
        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }
        #endregion

        #endregion

        static FrostyFolderPathControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FrostyFolderPathControl), new FrameworkPropertyMetadata(typeof(FrostyFolderPathControl)));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            Focusable = false;

            browseButton = GetTemplateChild(PART_BrowseButton) as Button;
            if (browseButton != null)
            {
                browseButton.Click += BrowseButton_Click;
            }
            
            openButton = GetTemplateChild(PART_OpenButton) as Button;
            if (openButton != null)
            {
                openButton.Click += OpenButton_Click;
            }
            
            clearButton = GetTemplateChild(PART_ClearButton) as Button;
            if (clearButton != null)
            {
                clearButton.Click += ClearButton_Click;
            }
        }

        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            var fbd = new VistaFolderBrowserDialog();
            
            if (fbd.ShowDialog() == true)
            {
                Text = fbd.SelectedPath;
            }
        }
        
        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            if (Directory.Exists(Text))
            {
                Process.Start(Text);
            }
        }
        
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            Text = "";
        }
    }
}
